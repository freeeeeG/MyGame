using UnityEngine.UI;
public class GMBtn : GMCommandBase
{
    public Button btn;
    public Text txt;
    public string cmd;
    public string desc;
    private void Start() 
    {
        btn = GetComponent<Button>();
        txt = GetComponentInChildren<Text>();
        btn.onClick.AddListener(OnClick);
    }
    public void Set(string cmd, string desc)
    {
        this.cmd = cmd;
        this.desc = desc;
        txt.text = cmd + " " + desc;
    }
    public virtual void OnClick()
    {
        
    }
}
