using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[RequireComponent(typeof(Text))]

public class TextLableBehavior : MonoBehaviour
{
	private Text lable;
	public UnityEvent startEvent;
	
	public void Start()
	{
		lable = GetComponent<Text>();
		startEvent.Invoke();
		
	}

	public void UpdateLable(FloatData obj)
	{
		lable.text = obj.value.ToString(CultureInfo.InvariantCulture);
	}
	public void UpdateLable(IntData obj)
	{
		lable.text = obj.value.ToString(CultureInfo.InvariantCulture);
	}
}
