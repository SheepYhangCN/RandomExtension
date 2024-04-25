| Languages |
|-|
| **English**, [简体中文](README_sChs.md), [繁體中文](README_tChs.md)|
# How to use
Add ```using SheepYhangCN.RandomExtension;``` at the head of your C# file

# References
```RandomX.Choose<T>(Random inst,value1,value2,value3...)``` => Random selected value<br>
```RandomX.ChooseInList<T>(Random inst,[value1,value2,value3...])``` => Random selected value<br>
```RandomX.FiftyFifty(Random inst)``` => true/false<br>
```RandomX.FiftyFifty<T>(Random inst,value1,value2)``` => 50% chance get value1, 50% chance get value2<br>
```RandomX.Chance(Random inst,chance in percent)``` => You inserted chance to get true, otherwise get false<br>
```RandomX.Chance<T>(Random inst,chance in percent,value1,value2,value3...)``` => You inserted chance to get value1, otherwise get a random value in [value2,value3...]<br>
```RandomX.ChanceInList<T>(Random inst,chance in percent,value1,[value2,value3...])``` => You inserted chance to get value1, otherwise get a random value in [value2,value3...]<br>
```RandomX.ChancePerItem<T>(Random inst,{[value1,chance],[value2,chance]...})``` => You inserted chances to get values