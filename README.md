# This is a scheme for the c# work: ***Schelendar*** (Schedule + Calendar)

## 产品介绍

| 产品定位 | 一款主打课表、日程管理的窗体应用                             |
| -------- | ------------------------------------------------------------ |
| 产品描述 | 学生可在课程管理页查看本周课表、增删改查课程信息，在日程管理页可看到当天课程的详细信息，并能添加事件备忘提醒，添加日程管理 |
| 目标人群 | 大学学生                                                     |
| 使用场景 | 查看课表，修改课程信息，设置备忘事件，添加日程管理           |

## 产品功能结构

### 用户端

- 导入学期课表

- 查看本周、学期课表
- 对课表进行增删课程操作
- 修改课程相关信息（上课时间、地点、周数等）
- 日程管理，增删备忘事件
- 查看当天课程及备忘事件
- 按照设定事件类型获得事件提醒

## 数据结构设计

### 类设计

### 数据库表设计

## 1. Description

### 1.1 Schedule
*Schedule*是传统的课表。

#### 包括的功能：
##### 用户层面
- 登录、登出、注销              ->获取用户ID信息
- 显示[课程信息](#class_desc)   ->查询对应ID的课程信息
- 导入课表，导出课表            ->导入导出为xml或者excel信息

##### 管理员层面（教秘）
- 对不同用户的课表的修改、添加与删除

<i id="class_desc"></i>*课程信息*包括课程名称、上课地点、时间、教室、持续周数

### 1.2 Calendar
*Calendar*是日历模块，显示星期几、事件提醒

#### 包括的功能：
- 显示星期几
- 创建、删除、更新[事件](#event_desc)
- 导入事件集合、导出事件
  - *导入事件集合*类似于加入节假日日历，通常有很多
  - *导出事件*我不知道这个功能有没有用，比如分享一个活动，感觉不会同时分享很多个。也可能是我用过的日历没法同时选中多个日历项:laughing:

<i id="event_desc"></i>*事件*包括时间、描述、地点、重复频率

## 2. 表的设计
两张表：*课程表* 和 *日历表*
两张表的不同应该在于：课程表需要从服务器获取，本地不能创建；日历表项本地可以创建=>日历需要同步到服务器吗？也就是说，必须联网登录才能使用吗？
### 2.1 课程表(Class)
#### 2.1.1 课程表项说明
|表项|说明|
|---|---|
|ClassID|课程号，会重复，not null|
|ClassName|课程名，会重复，not null|
|StartTime|开始时间|
|EndTime|结束时间|
|District|上课教室的校区|
|TeachingBuilding|上课教室的教学楼|
|Classroom|上课教室的教室号|
|Duration|持续时间，周数，拆成开始周和结束周|
|StartWeek|开始周|
|EndWeek|结束周|
|SemasterID|学期号|
|TeacherName|老师名，不需要创建老师表，也不作为索引，因此不用ID|
|StudentID|学生号，会重复，not null|
|StudentName|学生名，会重复，not null|
其中**ClassID+StudentID**可作为**主键**（不考虑重复选课情况？好像那种算重修课程？）

#### 2.1.2 例子
|ClassID|ClassName|StartTime|EndTime|District|TeachingBuilding|Classroom|StartWeek|EndWeek|SemasterID|TeacherName|StudentID|StudentName|
|---|:---:|---:|---:|---:|:---:|:---:|---:|---:|---:|---:|---:|:---:|  
|1|软件构造基础|2:05|16:30|3|2|109|1|12|大二下|贾向阳|1|张浩|
|1|软件构造基础|2:05|16:30|3|2|109|1|12|大二下|贾向阳|2|伍思烨|
|1|软件构造基础|2:05|16:30|3|2|109|1|12|大二下|贾向阳|3|龚书帆|
|2|离散数学|2:05|16:30|1|2|109|1|12|大一上|王汉飞|3|龚书帆|
|3|离散数学（重修）|2:05|16:30|1|2|109|1|12|大二上|王汉飞|3|龚书帆|

### 2.2 用户表(User)
#### 2.2.1 课程表项说明
|表项|说明|
|---|---|
|UserID|用户账号|
|Password|用户密码|
|UserMode|0态和3态，0表示超级用户（管理员），3表示普通学生|

#### 2.2.2 例子
|UserID|Password|UserMode|
|---|---|---|
|2020302111121|GSF123456~|3|
|114514|root|0|

### 2.3 日历表(Event)
看一看要不要写，好像现在就挺多的了:cry:
#### 2.3.1 课程表项说明
|表项|说明|
|---|---|
|EventID|事件ID，若不上传（放到网上）的话则为主键；若上传则与`USERID`共同作为主键，且用户处也要建表，自增一|
|EventInfo|事件描述|
|StartYear|开始年
|StartMonth|开始月
|StartDay|开始日
|StartHour|开始时
|StartMin|开始分
|EndYear|结束年，默认为`StartYear`
|EndMonth|结束月，默认为`StartMonth`
|EndDay|结束日，默认为`StartDay`
|EndHour|结束时，默认为`StartHour`+1h
|EndMin|结束分，默认为`StartMin`
|IsRepeat|是否重复。若不重复，则仅开始周有；反之从开始周后每周都有(感觉这个功能小麻烦:frowning:)
|UserID|用户的ID

#### 2.3.2 例子
|EventID|EventInfo|StartYear|StartMonth|StartDay|StartHour|StartMin|EndYear|EndMonth|EndDay|EndHour|EndMin|IsRepeat|UserID
|---|---|---|---|---|---|---|---|---|---|---|---|---|---|
|1|荒野乱斗|2022|5|8|16|00|2022|5|8|17|00|1|0|
|2|荒野乱斗|2022|5|11|16|00|2022|5|11|17|00|0|0|

## 3. 实现
### 3.1 数据的存储
- 对于课程表，本地应该保存（吗？）一个最后一次爬取时的副本（xml），
- 
### 3.2 数据的操作
操作在[主界面](#332-主界面主显示界面)中发起

### 3.3 界面的操作
#### 3.3.1 登录界面
在此界面进行登录操作
##### 默认登录吗？
- 好处：每次打开程序不用等刷新。可以直接看到自己的课表（基于应用程序是个人机器上，没有人会抢着用的假设）
- 坏处：要本地化数据；登录时有一个记住账户（或者这个功能是默认的？）、记住密码、自动登录功能；
    如果默认登录，则应该本地化用户信息。
##### 控件
|部件名|控件类型|描述
|---|---:|:---:|
|CBX_ID|combobox|用户ID，管理员和学生共用，登录成功则有不同权限。需要写学、工号（一串数字），检测|
|TXT_Passwd|textbox|密码,加掩码|
|CKB_RmbMe|checkbox|`记住我`，默认勾选。若取消，**自动**取消记住密码（对QQ的拙劣模仿）|
|CKB_Pwd|checkbox|`记住密码`，默认不勾选。若勾选，则**自动**勾选`记住我`|
|CKB_Auto|checkbox|`自动登录`，默认不勾选。若勾选，则**自动**勾选另外两个CheckBox。|
|登录|button|验证信息，若正确则保存三个CheckBox决定的内容。并跳转查询页面（主页面？）；否则不保存信息也不跳转，并进行提醒（错误MessageBox）

*疑问：* 管理员和学生共用一个页面，会不会暴露管理员的ID？这个信息应该保密吗
&nbsp;可能的解决方案：管理员`记住我`一项勾选与否不影响忽略ID？
*补充* 怎么在记住的账号中
#### 3.3.2 主界面（主显示界面）







​    

