/*
 * Copyright (c) 2017 Samsung Electronics Co., Ltd. All rights reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using SystemInfo.Model.Vibrator;
using SystemInfo.Tizen.Mobile.Service;
using Vibrator = Tizen.System.Vibrator;

[assembly: Xamarin.Forms.Dependency(typeof(VibratorService))]

namespace SystemInfo.Tizen.Mobile.Service
{
    /// <summary>
    /// Provides methods that allow to obtain information about device's vibrators.
    /// </summary>
    public class VibratorService : IVibrator
    {
        /// <summary>
        /// Gets the number of available vibrators.
        /// </summary>
        public int NumberOfVibrators => Vibrator.NumberOfVibrators;
    }
}