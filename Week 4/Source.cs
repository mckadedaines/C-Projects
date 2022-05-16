public class Source {

    private string name = "";
    private string url = "";

    public Source(string name, string url="") {
        // this.name is referencing the private string above, the 2nd name is referenceing the name in the constructor.
        this.name = name;
        this.url = url;
    }

    public string getName() {
        return name;
    }

    public string getURL(){
        return url;
    }
}