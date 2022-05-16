public class Quote {
    private string authoer = "";
    private string quote = "";
    private Source source;

    public Quote(string person, string quote, Source source){
        this.authoer = person;
        this.quote = quote;
        this.Source = source;
    }

    public bool HasAuthor(string name){
        if(authoer.ToUpper().Contains(name.ToUpper())){
            return true;
        }
        return false;
    }

    public string GetQuote(){
        string url = source.getUrl();
        // This is an inline IF statement
        // if(url != ""){
        //     url = $"[{url}]";
        // }
        // else {
        //     url = "";
        // }
        url = url != "" ? $"[{url}]" : "";
        return $"\"{quote}\"\n{author} - {source.getName()}{url}";
    }
}