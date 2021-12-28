# 安装

    Install-Package NLog.Config

# config

```
<?xml version="1.0" encoding="utf-8" ?>
<nlog
    xmlns="http://www.nlog-project.org/schemas/NLog.xsd"
    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
      xsi:schemaLocation="http://www.nlog-project.org/schemas/NLog.xsd NLog.xsd"
      autoReload="true"
      throwExceptions="false"
      internalLogLevel="Off“
      internalLogFile="c:\temp\nlog-internal.log">

    <variable name="myvar" value="myvalue"/>
    <targets></targets>
    <rules></rules>

</nlog>
```

> InternalLogFile="c:\log\nlog.txt" //NLog内部日志文件位置 
> internalLogLevel="Debug" //日志级别 
> autoReload="true" //配置变动后自动读取最新配置

> throwExceptions//NLog日志系统抛出异常
> internalLogFile="c:\log\nlog.txt" //NLog内部日志文件位置 
> internalLogLevel="Debug" //日志级别 

## `variable`

```
定义配置文件中用到的变量
```



## target

```
定义日志的目标/输出
```



### `type`

    文件
    文本控制台
    Email
    数据库
    网络中的其它计算机（通过TCP或UDP）
    基于MSMQ的消息队列
    Windows系统日志

### `layout`

```
${activityid}   将其置入日志System.Diagnostics trace 
${all-event-properties} 事件日志上下文
${appdomain}    当前应用程序域
${assembly-version} 应用程序
${basedir}  应用程序域的基本目录。
${callsite} (类名称、方法名称和相关信息的源信息)。
${callsite-linenumber}  调用类的
${counter}  数值
${date} 当前日期和时间。
${document-uri} 用于Silverlight应用。
${environment}  环境变量
${event-properties}  
${exception}    exception信息
${file-contents}    显示指定文件的内容
${gc}   垃圾收集器
${gdc}  诊断上下文
${guid} GUID
${identity} 线程标识信息
${install-context}  安装参数
${level}    级别。
${literal}   
${log4jxmlevent}    XML事件描述
${logger}   记录器的名字
${longdate} 日期和时间的格式分类yyyy-MM-dd HH:mm:ss.ffff。
${machinename}  名称
${mdc}  映射诊断
${mdlc} 异步映射诊断上下文
${message}  消息
${ndc}  线程结构
${ndlc} 异步线程
${newline}  文字换行
${nlogdir}  nlog.dll目录。
${performancecounter}   述性能计数器。
${processid}    当前进程标识符
${processinfo}  运行信息
${processname}  当前进程的名称。
${processtime}  该时间过程中格式HH:MM:ss.mmm。
${qpc}  高精度定时器，基于返回的值从queryperformancecounter(任选地)转换为秒。
${registry} 从注册表中的值。
${sequenceid}   ID
${shortdate}    短时间 格式YYYY-MM-DD。
${sl-appinfo}   Silverlight应用。
${specialfolder}    文件夹路径
${stacktrace} - 堆栈跟踪渲染器。
${tempdir}  临时目录中。
${threadid} 当前线程的标识符。
${threadname}   当前线程。
${ticks}    当前日期和时间。
${time} 24小时格式HH:MM:ss.mmm。
${var}  {$var}-提供新的变量(4.1)
${windows-identity} indows线程标识信息(用户名)
```



## rule

```
定义日志的路由规则
```



### `log level`

```
Trace- 最常见的记录信息，一般用于普通输出

Debug- 同样是记录信息，不过出现的频率要比Trace少一些，一般用来调试程序

Info- 信息类型的消息

Warn- 警告信息，一般用于比较重要的场合

Error- 错误信息

Fatal- 致命异常信息。一般来讲，发生致命异常之后程序将无法继续执行。
```

