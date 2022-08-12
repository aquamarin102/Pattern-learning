using UnityEngine;
using Zoork.Interfaces;

internal sealed class Health :  IHeath
{
    private readonly float _maxHealth;
    private float _curHealth;

    public Health(float maxHP, float curHP)
    {
        _maxHealth = maxHP;
        _curHealth = curHP;
    }

    public void ChangedHP(float changHP, GameObject player)
    {
        _curHealth += changHP;
        if (_curHealth >= _maxHealth)
        {
            _curHealth = _maxHealth;
        }

        if (_curHealth <= 0)
        {
            player.SetActive(false);
        }
    }
}
