using System;

[Serializable]
 public class SerializedClass
 {
     public String name;
     public float value1;
     public float value2;
 
     public override string ToString()
     {
         return name + "[ " + value1 + " ," + value2 + " ]";
     }
 }
