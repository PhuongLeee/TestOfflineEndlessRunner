using UnityEngine;

public class DataDeleteConfirmation : MonoBehaviour
{
    protected LoadoutState m_LoadoutState;
    public Animator animator;
    protected const string closeAnimState = "SettingConfirmClose";

    public void Open(LoadoutState owner)
    {
        gameObject.SetActive(true);
        m_LoadoutState = owner;
    }

    public void Close()
    {
        animator.Play(closeAnimState);
    //    gameObject.SetActive(false);
    }

    public void Hide() {
        gameObject.SetActive(false);
    }

    public void Confirm()
    {
        PlayerData.NewSave();
        m_LoadoutState.UnequipPowerup();
        m_LoadoutState.Refresh();
        Close();
    }

    public void Deny()
    {
        Close();
    }
}
