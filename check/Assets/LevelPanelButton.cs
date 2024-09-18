
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelPanelButton : MonoBehaviour
{
    [SerializeField] private GameObject _button;
    [SerializeField] private GameObject _buttonEmpty;
    [SerializeField] private GameObject _panel;
    [SerializeField] private int _buttons = 0;
    [SerializeField] private int _completedLevels = 0;
    bool _isShowed = false;
    public void _ShowPanel()
    {
        if( _isShowed == false)
        {

            for (int i = 0; i < _buttons; i++)
            {
                GameObject _currentButton = null;
                if (_completedLevels > i)
                {
                     _currentButton = Instantiate(_button, _panel.transform);
                    _currentButton.GetComponentInChildren<TextMeshProUGUI>().text = (i + 1).ToString();
                }
                else
                {
                     _currentButton = Instantiate(_buttonEmpty, _panel.transform);
                }
                   
              
            }
            _panel.SetActive(true);
            _isShowed = true;
        }
        else
        {
            Button[] _spawnedButtons = _panel.GetComponentsInChildren<Button>();
            for (int i = 0; i < _buttons; i++)
            {
                Destroy(_spawnedButtons[i].gameObject);
            }
            _panel.SetActive(false);
            _isShowed= false;
        }
      
    }
}
