# CalculatorWPFHomework
## Overview
This project contains 6 projects, the main projects for this homework are:
* Calculator
* CalculatorWPF

The other projects were created during the lab to learn how to write unit tests as well as a breif look at windows forms before moving on to WPF (Windows Presentation Foundation) 

The WPF calculator:

![alt text](https://i.imgur.com/xrtalwt.png "SimpleCalculator")

## Implementation

```csharp
CalculatorUnderTest calc = new CalculatorUnderTest();

private void Button_Click(object sender, RoutedEventArgs e)
{          
  MessageBox.Show(OperationComboBox.Text);

  string selectedItem = OperationComboBox.Text;
  double value1 = Double.Parse(val1TextBox.Text);
  double value2 = Double.Parse(val2TextBox.Text);
  double result = 0;          

  switch (selectedItem)
  {
    case "Add":
      result = calc.Add(value1, value2);
      MessageBox.Show(result.ToString());                  
      break;
    case "Subtract":
      result = calc.Subtract(value1, value2);
      MessageBox.Show(result.ToString());
      break;
    case "Multiply":
      result = calc.Multiply(value1, value2);
      MessageBox.Show(result.ToString());
      break;
    case "Divide":
      result = calc.Divide(value1, value2);
      MessageBox.Show(result.ToString());
      break;
    default:
      MessageBox.Show("Invalid");
      break;
   }
}
```
