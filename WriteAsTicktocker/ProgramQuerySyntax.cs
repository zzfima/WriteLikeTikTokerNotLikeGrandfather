internal class ProgramQuerySyntax
{
    record Configuration(IList<Client> Clients);
    record Client(IList<Stage> Stages, string Name);
    record Stage(IList<Host> Hosts, string Name);
    record Host(string Name, int ping);

    private static void MainQuerySyntax(string[] args)
    {
        var configuration = new Configuration(
            new List<Client>() {
                new Client(new List<Stage>(){
                    new Stage(new List<Host>(){
                        new Host("H100", 312),
                        new Host("H101", 322),
                        new Host("H102", 332),
                    }, "S10"),
                    new Stage(new List<Host>(){
                        new Host("H110", 342),
                        new Host("H111", 352),
                        new Host("H112", 362),
                    }, "S111"),
                    new Stage(new List<Host>(){
                        new Host("H120", 372),
                        new Host("H121", 382),
                        new Host("H122", 392),
                    }, "S12"),
                }, "C111"),
                new Client(new List<Stage>(){
                    new Stage(new List<Host>(){
                        new Host("H200", 132),
                        new Host("H201", 232),
                        new Host("H202", 332),
                    }, "S20"),
                    new Stage(new List<Host>(){
                        new Host("H210", 432),
                        new Host("H111", 532),
                        new Host("H212", 632),
                    }, "S111"),
                    new Stage(new List<Host>(){
                        new Host("H220", 732),
                        new Host("H111", 832),
                        new Host("H222", 932),
                    }, "S111"),
                }, "C111"),
                new Client(new List<Stage>(){
                    new Stage(new List<Host>(){
                        new Host("H300", 321),
                        new Host("H301", 322),
                        new Host("H302", 323),
                    }, "S30"),
                    new Stage(new List<Host>(){
                        new Host("H310", 321),
                        new Host("H311", 3223),
                        new Host("H312", 324),
                    }, "S31"),
                    new Stage(new List<Host>(){
                        new Host("H320", 325),
                        new Host("H321", 326),
                        new Host("H322", 327),
                    }, "S32"),
                }, "C3"),
                new Client(new List<Stage>(){
                    new Stage(new List<Host>(){
                        new Host("H400", 327),
                        new Host("H401", 328),
                        new Host("H402", 329),
                    }, "S40"),
                    new Stage(new List<Host>(){
                        new Host("H410", 3233),
                        new Host("H411", 3244),
                        new Host("H412", 3255),
                    }, "S41"),
                    new Stage(new List<Host>(){
                        new Host("H420", 3266),
                        new Host("H421", 3277),
                        new Host("H422", 3288),
                    }, "S42"),
                }, "C4"),
            });


        var find = FindHost(configuration, "C111", "S111", "H111");

        Console.ReadLine();
    }

    /*
    record Configuration(IList<Client> Clients);
    record Client(IList<Stage> Stages, string Name);
    record Stage(IList<Host> Hosts, string Name);
    record Host(string Name);
    */

    static IEnumerable<Host> FindHost(Configuration configuration, string clientName, string stageName, string hostName)
    {
        List<Host> hosts1 = new List<Host>();
        foreach (var client in configuration.Clients)
        {
            if (client.Name == clientName)
            {
                foreach (var stage in client.Stages)
                {
                    if (stage.Name == stageName)
                    {
                        foreach (var host in stage.Hosts)
                        {
                            if (host.Name == hostName)
                            {
                                hosts1.Add(host);
                            }
                        }
                    }
                }
            }
        }

        //query syntax
        var hosts2 =
            from client in configuration.Clients
            where client.Name == clientName

            from stage in client.Stages
            where stage.Name == stageName

            from host in stage.Hosts
            where host.Name == hostName

            select host;


        return hosts2;
    }
}