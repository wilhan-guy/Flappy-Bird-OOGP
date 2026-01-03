using UnityEngine;

// 1. INHERITANCE: Mewarisi semua properti dari ObstacleBase
public class PipeController : ObstacleBase
{
    // 2. POLYMORPHISM: Implementasikan method Move() yang diwajibkan oleh Base Class
    public override void Move()
    {
        // Logika Pergerakan Pipa ke kiri (Implementasi spesifik Pipa)
        Vector3 newPosition = transform.position;
        newPosition.x -= speed * Time.deltaTime; // Akses 'speed' dari base class
        transform.position = newPosition;
    }
}
