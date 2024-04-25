# 如何使用
把 ```using SheepYhangCN.RandomExtension;``` 添加到你C#文件的开头

# References
```RandomX.Choose<T>(Random实例,value1,value2,value3...)``` => 随机选择value<br>
```RandomX.ChooseInList<T>(Random实例,[value1,value2,value3...])``` => 随机选择value<br>
```RandomX.FiftyFifty(Random实例)``` => true/false<br>
```RandomX.FiftyFifty<T>(Random实例,value1,value2)``` => 50%概率返回value1，50%概率返回value2<br>
```RandomX.Chance(Random实例,百分制概率)``` => 你输入的概率返回true，否则返回false<br>
```RandomX.Chance<T>(Random实例,百分制概率,value1,value2,value3...)``` => 你输入的概率返回true，否则从[value2,value3...]中随机返回一个<br>
```RandomX.ChanceInList<T>(Random实例,百分制概率,value1,[value2,value3...])``` => 你输入的概率返回true，否则从[value2,value3...]中随机返回一个<br>
```RandomX.ChancePerItem<T>(Random实例,{[value1,概率],[value2,概率]...})``` => 从你输入的概率来返回值