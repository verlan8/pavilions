﻿using pavilions.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pavilions.Commands
{
    internal class RelayCommand : CommandBase
    {
        private readonly Action<object> _Execute;

        private readonly Func<object, bool> _CanExecute;

        public RelayCommand(Action<object> Execute, Func<object, bool> CavExecute = null)
        {
            _Execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
            _CanExecute = CanExecute;
        }

        public override bool CanExecute(object parameter) => _CanExecute?.Invoke(parameter) ?? true;

        public override void Execute(object parameter) => _Execute(parameter);
    }
}
