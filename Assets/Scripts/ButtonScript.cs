using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ButtonScript : MonoBehaviour
{
    public AssetSO LetterAssets;
    private char _value;
    private Image _image;
    public void OnClick()
    {
        AnswerScript.Instance.Answer(_value);
    }
    public void SetValue(char value)
    {
        _value = value;
        var asset = LetterAssets.Assets.FirstOrDefault(x => x.Letter == value);
        if (asset != null)
        {
            _image.sprite = asset.texture;
            _image.SetNativeSize();
        }
    }
    private void Awake()
    {
        _image = GetComponent<Image>();  
    }
}
