public class Word
{
    private string _text;
    private bool _visible;

    public Word(string text_input)
    {
        _text = text_input;
        _visible = true;
    }
    public void ToggleVisibility()
    {
        if (_visible == true)
        {
            _visible = false;
        } else if(_visible == false)
        {
            _visible = true;
        }
    }
    public string GetWord()
    {
        string returnedWord = "";
        if (_visible == true)
        {
            returnedWord = _text;
        }else if(_visible == false)
        {
            foreach (char letter in _text){
                
                returnedWord += "_"; 
            }
        }
        return returnedWord;
    }
}