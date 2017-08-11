// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

namespace osu.Framework.Input.Bindings
{
    /// <summary>
    /// A binding of a <see cref="KeyCombination"/> to an action.
    /// </summary>
    public class KeyBinding
    {
        /// <summary>
        /// The combination of keys which will trigger this binding.
        /// </summary>
        public KeyCombination Keys;

        /// <summary>
        /// The resultant action which is triggered by this binding.
        /// This is an <see cref="int"/> representation of an enum type.
        /// </summary>
        public int Action;

        /// <summary>
        /// Construct a new instance.
        /// </summary>
        /// <param name="keys">The combination of keys which will trigger this binding.</param>
        /// <param name="action">The resultant action which is triggered by this binding. Usually an enum type.</param>
        public KeyBinding(KeyCombination keys, object action)
        {
            Keys = keys;
            Action = (int)action;
        }

        /// <summary>
        /// Constructor for derived classes that may require serialisation.
        /// </summary>
        public KeyBinding()
        {
        }

        /// <summary>
        /// Get the action associated with this binding, cast to the required enum type.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <returns>A cast <see cref="T"/> representation of <see cref="Action"/>.</returns>
        public virtual T GetAction<T>() => (T)(object)Action;

        public override string ToString() => $"{Keys}=>{Action}";
    }
}