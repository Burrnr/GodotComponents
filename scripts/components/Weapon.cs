using Godot;

namespace waititsallcomponents.scripts.components;

public partial class Weapon: Node2D {
    private float _fireRate = 0.5f;
    private float _damage = 10f;
    private float _bulletSpeed = 100f;
    private PackedScene _bullet;
}