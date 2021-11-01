namespace core
{
    interface LogInterface
    {
        LogInterface log(string str);
        LogInterface write();
        //отвечает за запись во временное хранилище (в каком виде будет это хранилище необходимо решить самому) строк логов.
    }
}
