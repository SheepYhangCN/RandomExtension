# 如何使用
把 ```using SheepYhangCN.RandomExtension;``` 添加到你C#文件的开头

# References
```<Random实例>.Choose<T>(value1,value2,value3...)``` => 随机选择value<br>
```<Random实例>.FiftyFifty()``` => true/false<br>
```<Random实例>.FiftyFifty<T>(value1,value2)``` => 50%概率返回value1，50%概率返回value2<br>
```<Random实例>.Chance(概率)``` => 你输入的概率返回true，否则返回false<br>
```<Random实例>.Chance<T>(概率,value1,value2,value3...)``` => 你输入的概率返回value1，否则从[value2,value3...]中随机返回一个<br>
```<Random实例>.ChancePerItem<T>({[value1,概率],[value2,概率]...})``` => 从你输入的概率来返回值