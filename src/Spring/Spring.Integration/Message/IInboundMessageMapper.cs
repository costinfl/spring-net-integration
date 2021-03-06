#region License

/*
 * Copyright 2002-2009 the original author or authors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF Any KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#endregion

using Spring.Integration.Core;

namespace Spring.Integration.Message {
    /// <summary>
    /// Strategy interface for mapping from an Object to a <see cref="IMessage"/>.
    /// </summary>
    /// <author>Mark Fisher</author>
    /// <author>Andreas D�hring (.NET)</author>
    public interface IInboundMessageMapper {

        /// <summary>
        /// map <paramref name="obj"/> to a <see cref="IMessage"/>
        /// </summary>
        /// <param name="obj">the object to map</param>
        /// <returns>the <see cref="IMessage"/> mapped with <paramref name="obj"/></returns>
        IMessage ToMessage(object obj);
    }
}
