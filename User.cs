namespace mis221_pa3_glsaacke
{
    //EXTRAS***
    public class User
    {
        //Class variables
        private string firstName;
        private int hours;
        private int wheelHours;
        private int passHours;

        //Constructor
        public User(string firstName, int hours, int wheelHours, int passHours){

            this.firstName = firstName;
            this.hours = hours;
            this.wheelHours = wheelHours;
            this.passHours = passHours;
        }

        //Class methods
        public string GetFirstName(){
            return firstName;
        }

        public void SetFirstName(string firstName){
            this.firstName = firstName;
        }


        public int GetHours(){
            return hours;
        }
        public void SetHours(int inputHours){
            this.hours = inputHours;
        }


        public int GetWheelHours(){
            return wheelHours;
        }
        public void SetWheelHours(int inputWheelHours){
            wheelHours = inputWheelHours;
        }
        public void MathWheelHours(int num){ //Adds/subtracts the approptiate value
            this.wheelHours = wheelHours += num;
        }


        public int GetPassHours(){
            return passHours;
        }
        public void SetPassHours(int inputPassHours){
            this.passHours = inputPassHours;
        }
        public void IncrementPassHours(){
            passHours++;
        }
    }
}