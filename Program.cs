namespace David;

static class Program{

    //static abuse is life owo
    public static David instance = new David();

    static void Main(){
        ApplicationConfiguration.Initialize();
        Application.Run(instance);
    }    
}