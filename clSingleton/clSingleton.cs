
namespace DesignPatterns

{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }

        // private konstruktor, 
        // hogy ne tudjuk kívülről példányosítani (new)
        private Singleton() { }

        // static konstruktor
        // Azok az osztályok, melyeknek nincs static konstruktora
        // azok az IL kódban beforefieldinit attribútumot kapnak
        // ami arra jó, hogy a static tagok inicializációja a program elején
        // azonnal megtörténik
        // míg azok az osztályok, melyeknek van static konstruktora,
        // azokban a static tagok akkor inicializálódnak, amikor elsőnek hivatkozunk az osztályra
        // azaz amikor majd elkérjük a példányt
        static Singleton() { }
    }
}
