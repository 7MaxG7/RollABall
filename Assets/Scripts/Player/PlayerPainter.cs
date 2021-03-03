using UnityEngine;

namespace MaxG
{
    
    public class PlayerPainter : MonoBehaviour {
        private Animator _anim;
        // private StuffTakenEvent _stuffTakenEvent;
        private readonly int _recolorTrigger = Animator.StringToHash("recolor");
        private float _lifeTime = 1;
        
        private void Awake() {
            _anim = GetComponent<Animator>();
            _anim.SetTrigger(_recolorTrigger);
            Destroy(this, _lifeTime);
            // _stuffTakenEvent = FindObjectOfType<GameLogic>().StuffTakenEvent;
        }
        // private void Start() {
        //     _stuffTakenEvent.AddListener(AnimateBallColorChanging);
        // }
        
        // private void AnimateBallColorChanging(GameObject @null) {
        // _anim.SetTrigger(_recolorTrigger);
        // }
    }
}