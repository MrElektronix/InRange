using UnityEngine;

namespace Assets
{
    public class Range : MonoBehaviour
    {


        private Collider[] _hitColliders;
        private float _radius;
        private int _layerid;
        private int _layermask;
        private float _speed;


        private void Start()
        {
            _speed = 4f;
            _layerid = 8;
            _layermask = 1 << _layerid;

            _radius = 3f;


        }

        private void Update()
        {
            float step = _speed * Time.deltaTime;
            _hitColliders = Physics.OverlapSphere(transform.position, _radius, _layermask);

            foreach (var col in _hitColliders)
            {
                transform.position = Vector3.MoveTowards(transform.position, col.transform.position, step);
            }


        }

    }
}
