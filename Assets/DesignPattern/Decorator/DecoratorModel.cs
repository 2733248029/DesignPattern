using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DocoratorModelTest
{
    public class DecoratorModel : MonoBehaviour
    {
        private void Start()
        {
            HeadEquipment headEquipment = new HeadEquipment();
            headEquipment.EquipmentName = "头盔";
            BorderDecorator border = new BorderDecorator(headEquipment);
            border.ShowInfo();
        }
    }
    public abstract class Equipment
    {
        public  string EquipmentName { get; set; }
        public abstract void ShowInfo();

        public virtual string  GetEquipmentName()
        {
            return EquipmentName;
        }

    }
    public class HeadEquipment : Equipment
    {
        public override void ShowInfo()
        {
            Debug.Log("装备名字:" + EquipmentName);
        }
    }
    public abstract class Decorator : Equipment
    {
        Equipment equipment;
        public Decorator(Equipment equipment)
        {
            this.equipment = equipment;
        }

        public override void ShowInfo()
        {
            equipment.ShowInfo();
        }
        public override string GetEquipmentName()
        {
           return equipment.GetEquipmentName();
        }
    }
    public class BorderDecorator : Decorator
    {
        Border border = new Border();
        public BorderDecorator(Equipment equipment) : base(equipment) { }
        public override void ShowInfo()
        {
            base.ShowInfo();
            border.ShowInfo(this);
        }
    }
    public abstract class Additional
    {
        public abstract void ShowInfo(Equipment equipment);

    }
    public class Border : Additional
    {
        public override void ShowInfo(Equipment equipment)
        {
            Debug.Log("Border" + equipment.GetEquipmentName());
        }
    }

}

