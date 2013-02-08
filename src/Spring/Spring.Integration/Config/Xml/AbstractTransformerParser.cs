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

using System.Xml;
using Spring.Objects.Factory.Support;
using Spring.Objects.Factory.Xml;

namespace Spring.Integration.Config.Xml {
    /// <author>Mark Fisher</author>
    /// <author>Andreas D�hring (.NET)</author>
    public abstract class AbstractTransformerParser : AbstractConsumerEndpointParser {

        protected override ObjectDefinitionBuilder ParseHandler(XmlElement element, ParserContext parserContext) {
            ObjectDefinitionBuilder builder = ObjectDefinitionBuilder.GenericObjectDefinition(IntegrationNamespaceUtils.TRANSFORMER_PACKAGE + ".MessageTransformingHandler");
            ObjectDefinitionBuilder transformerBuilder = ObjectDefinitionBuilder.GenericObjectDefinition(TransformerClassName);
            ParseTransformer(element, parserContext, transformerBuilder);
            string transformerBeanName = parserContext.ReaderContext.RegisterWithGeneratedName(transformerBuilder.ObjectDefinition);
            builder.AddConstructorArgReference(transformerBeanName);
            return builder;
        }

        protected abstract string TransformerClassName { get; }

        protected abstract void ParseTransformer(XmlElement element, ParserContext parserContext, ObjectDefinitionBuilder builder);
    }
}