using PetSimulator.OopCode;
using PetSimulator.ProcCode;
using PetSimulator.UI.Abstractions;

namespace PetSimulatorApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            createPetButton.Enabled = false;
            performActionButton.Enabled = false;
        }

        private IPetService _petService;

        private void loadButton_Click(object sender, EventArgs e)
        {
            LoadPetService();
            FillUi();

        }

        private void LoadPetService()
        {
            if (proceduralModeRadioButton.Checked)
                _petService = new ProcPetService();
            else if (oopModeRadioButton.Checked)
                _petService = new OopPetService();
            else
                throw new ApplicationException("No valid Pet Service has been selected.");
        }

        private void FillUi()
        {
            createPetButton.Enabled = true;
            var pets = _petService.GetPets();
            petListBox.Items.Clear();
            petListBox.DataSource = pets;
            petListBox.DisplayMember = "DisplayName";
            petListBox.SelectedIndex = 0;

            var selectedPet = (IUiDisplayItem)petListBox.SelectedValue;

            var actions = _petService.GetActions(selectedPet);
            petActionListBox.Items.Clear();
            petActionListBox.DataSource = actions;
            petActionListBox.DisplayMember = "DisplayName";
        }

        private void createPetButton_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.Text;
            if (string.IsNullOrWhiteSpace(name))
                MessageBox.Show(this,
                    "You must give your pet a name!",
                    "ERROR - Missing Pet Name",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            var petSelection = (IUiDisplayItem)petListBox.SelectedValue;

            var greeting = _petService.MakePet(petSelection, name);
            PetDisplayClear();
            PetDisplayAppendLine(greeting);

            performActionButton.Enabled = true;
        }

        private void performActionButton_Click(object sender, EventArgs e)
        {
            var actionSelection = (IUiDisplayItem)petActionListBox.SelectedValue;
            var actionResult = _petService.PerformAction(actionSelection);
            PetDisplayAppendLine(actionResult);
        }

        List<string> petDisplayLines = new List<string>();

        private void PetDisplayClear()
        {
            petDisplayLines.Clear();
            textBox1.Lines = petDisplayLines.ToArray();
        }


        private void PetDisplayAppendLine(string line)
        {
            petDisplayLines.Add(line);
            textBox1.Lines = petDisplayLines.ToArray();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
