| Languages |
|-|
| **English**, [简体中文](README_sChs.md), [繁體中文](README_tChs.md)|
# How to use
Add ```using SheepYhangCN.RandomExtension;``` at the head of your C# file

# References
```<RandomInst>.Choose<T>(value1,value2,value3...)``` => Random selected value<br>
```<RandomInst>.FiftyFifty()``` => true/false<br>
```<RandomInst>.FiftyFifty<T>(value1,value2)``` => 50% chance get value1, 50% chance get value2<br>
```<RandomInst>.Chance(chance)``` => You inserted chance to get true, otherwise get false<br>
```<RandomInst>.Chance(dividend,divisor)``` => You inserted chance to get true, otherwise get false<br>
```<RandomInst>.Chance<T>(chance,value1,value2,value3...)``` => You inserted chance to get value1, otherwise get a random value in [value2,value3...]<br>
```<RandomInst>.ChancePerItem<T>({[value1,chance],[value2,chance]...})``` => You inserted chances to get values