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



    }
}
