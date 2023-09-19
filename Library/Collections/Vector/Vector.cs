namespace Library.Collections.Vector;

public class Vector<T>
{
    /* TODO: 
     *  - Добавление объекта в конец;
     *  - Удаление объекта;
     *  - Индексатор;
     *  - Создание из существующей коллекции;
     *  - Копирование;
     *  - Добавление;
     *  
     *  будет дополняться.
     */

    // Размер вектора по умолчанию
    private const int DEFAULT_SIZE = 10;

    // Хранилище элементов вектора
    private T?[] _storage;
    // Заполненность вектора элементами
    private long _fullness;

    /// <summary>
    /// Создание нового вектора без элементов. 
    /// Размер вектора по умолчанию: <see cref="DEFAULT_SIZE"/>. />
    /// </summary>
    public Vector()
    {
        _storage = new T[DEFAULT_SIZE];
        _fullness = 0;
    }

    /// <summary>
    /// Создание нового вектора из массива.
    /// </summary>
    /// <param name="storage">Исходный массив, элементы которого являются основой экземпляра вектора.</param>
    public Vector(T[] storage)
    {
        _storage = storage;
        _fullness = storage.Length;
    }

    public T? this[ulong index]
    {
        get => _storage[index];
        set => _storage[index] = value;
    }
}