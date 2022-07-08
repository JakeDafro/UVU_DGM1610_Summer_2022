using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class TextLableBehavior : MonoBehaviour
{
	public Text lable;
	public FloatData dataObj;

	public void Start()
	{
		lable = GetComponent<Text>();
		UpdateLable();
	}

	public void UpdateLable()
	{
		lable.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
	}
}
