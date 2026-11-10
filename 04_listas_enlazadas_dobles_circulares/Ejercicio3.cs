using System;
using System.Text;

class TrackNode
{
    public string titulo;
    public TrackNode next;
    public TrackNode prev;

    public TrackNode(string titulo)
    {
        this.titulo = titulo;
        this.next = null;
        this.prev = null;
    }
}

public class MusicPlayer
{
    private TrackNode current; // Puntero a la pista en reproducción actual

    public MusicPlayer()
    {
        this.current = null;
    }

    // Agregar pista al final de la lista circular
    public void AgregarPista(string titulo)
    {
        TrackNode newNode = new TrackNode(titulo);
        if (current == null)
        {
            current = newNode;
            current.next = current;
            current.prev = current;
        }
        {
            TrackNode tail = current.prev;
            tail.next = newNode;
            newNode.prev = tail;
            newNode.next = current;
            current.prev = newNode;
        }
        Console.WriteLine($"[Agregada] {titulo}");
    }

    // Avanzar a la siguiente pista
    public void Siguiente()
    {
        if (current != null)
        {
            current = current.next;
            Console.WriteLine($"-> Reproduciendo siguiente: {current.titulo}");
        }
    }

    // Retroceder a la pista anterior
    public void Anterior()
    {
        if (current != null)
        {
            current = current.prev;
            Console.WriteLine($"<- Reproduciendo anterior: {current.titulo}");
        }
    }

    // Eliminar la pista en curso (current) y pasar a la siguiente sin romper el ciclo
    public void EliminarPistaActual()
    {
        if (current == null)
        {
            Console.WriteLine("El reproductor está vacío.");
            return;
        }

        Console.WriteLine($"[Eliminando pista en curso] {current.titulo}");

        // CASO 1: Solo queda una pista en el reproductor
        if (current.next == current)
        {
            current = null;
            Console.WriteLine("El reproductor ahora está vacío.");
            return;
        }

        // CASO 2: Hay dos o más pistas
        TrackNode nodoAEliminar = current;
        TrackNode nodoAnterior = nodoAEliminar.prev;
        TrackNode nodoSiguiente = nodoAEliminar.next;

        // Reenlazar los adyacentes ignorando el nodo actual
        nodoAnterior.next = nodoSiguiente;
        nodoSiguiente.prev = nodoAnterior;

        // Mover çurrent'a la pista siguiente para mantener la reproducción fluida
        current = nodoSiguiente;

        Console.WriteLine($"Reproducción reanudada en: {current.titulo}");
    }

    // Mostrar el estado actual de la lista del reproductor
    public void MostrarPlaylist()
    {
        if (current == null)
        {
            Console.WriteLine("Playlist vacía.");
            return;
        }

        TrackNode temp = current;
        StringBuilder sb = new StringBuilder();
        {
            if (temp == current)
                sb.Append($"[{temp.titulo}]"); // Destaca la pista en curso
                sb.Append(temp.titulo);

            temp = temp.next;
            if (temp != current) sb.Append(" ⇄ ");
        } while (temp != current);

        Console.WriteLine("Playlist: " + sb.ToString());
    }

    // Método principal de prueba
    public static void Main(string[] args)
    {
        // Forzar UTF-8 en consola para las flechas ⇄
        Console.OutputEncoding = Encoding.UTF8;

        MusicPlayer reproductor = new MusicPlayer();

        // 1. Agregar pistas
        reproductor.AgregarPista("Canción A");
        reproductor.AgregarPista("Canción B");
        reproductor.AgregarPista("Canción C");
        reproductor.AgregarPista("Canción D");

        Console.WriteLine("\n--- Estado Inicial ---");
        reproductor.MostrarPlaylist(); // Activa: [Canción A]

        // 2. Rotar reproductor
        Console.WriteLine("\n--- Rotación ---");
        reproductor.Siguiente(); // Pasa a Canción B
        reproductor.MostrarPlaylist();

        // 3. Eliminar pista en curso (Canción B)
        Console.WriteLine("\n--- Eliminación de Pista Activa ---");
        reproductor.EliminarPistaActual(); // Debe borrar B y saltar automáticamente a C
        reproductor.MostrarPlaylist();

        // 4. Eliminar todas las pistas restantes secuencialmente
        Console.WriteLine("\n--- Eliminando el resto de pistas ---");
        reproductor.EliminarPistaActual(); // Borra C, salta a D
        reproductor.EliminarPistaActual(); // Borra D, salta a A
        reproductor.EliminarPistaActual(); // Borra A (última pista)
        reproductor.MostrarPlaylist();
    }
}