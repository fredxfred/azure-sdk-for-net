// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Personalizer.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Request a set of actions to be ranked by the Personalizer service.
    /// </summary>
    public partial class RankRequest
    {
        /// <summary>
        /// Initializes a new instance of the RankRequest class.
        /// </summary>
        public RankRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RankRequest class.
        /// </summary>
        /// <param name="actions">The set of actions the Personalizer service
        /// can pick from.
        /// The set should not contain more than 50 actions.
        /// The order of the actions does not affect the rank result but the
        /// order
        /// should match the sequence your application would have used to
        /// display them.</param>
        /// <param name="contextFeatures">Features of the context used for
        /// Personalizer as a
        /// dictionary of dictionaries. This depends on the application, and
        /// typically includes features about the current user, their
        /// device, profile information, data about time and date, etc.</param>
        /// <param name="excludedActions">The set of action ids to exclude from
        /// ranking.</param>
        /// <param name="eventId">Optionally pass an eventId that uniquely
        /// identifies this Rank event.
        /// If null, the service generates a unique eventId. The eventId will
        /// be used for
        /// associating this request with its reward, as well as seeding the
        /// pseudo-random
        /// generator when making a Personalizer call.</param>
        /// <param name="deferActivation">Send false if the user will see the
        /// rank results, therefore
        /// Personalizer will expect a Reward call, otherwise it will assign
        /// the default
        /// Reward to the event. Send true if it is possible the user will not
        /// see the
        /// rank results, because the page is rendering later, or the Rank
        /// results may be
        /// overridden by code further downstream.</param>
        public RankRequest(IList<RankableAction> actions, IList<object> contextFeatures = default(IList<object>), IList<string> excludedActions = default(IList<string>), string eventId = default(string), bool? deferActivation = default(bool?))
        {
            ContextFeatures = contextFeatures;
            Actions = actions;
            ExcludedActions = excludedActions;
            EventId = eventId;
            DeferActivation = deferActivation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets features of the context used for Personalizer as a
        /// dictionary of dictionaries. This depends on the application, and
        /// typically includes features about the current user, their
        /// device, profile information, data about time and date, etc.
        /// </summary>
        [JsonProperty(PropertyName = "contextFeatures")]
        public IList<object> ContextFeatures { get; set; }

        /// <summary>
        /// Gets or sets the set of actions the Personalizer service can pick
        /// from.
        /// The set should not contain more than 50 actions.
        /// The order of the actions does not affect the rank result but the
        /// order
        /// should match the sequence your application would have used to
        /// display them.
        /// </summary>
        [JsonProperty(PropertyName = "actions")]
        public IList<RankableAction> Actions { get; set; }

        /// <summary>
        /// Gets or sets the set of action ids to exclude from ranking.
        /// </summary>
        [JsonProperty(PropertyName = "excludedActions")]
        public IList<string> ExcludedActions { get; set; }

        /// <summary>
        /// Gets or sets optionally pass an eventId that uniquely identifies
        /// this Rank event.
        /// If null, the service generates a unique eventId. The eventId will
        /// be used for
        /// associating this request with its reward, as well as seeding the
        /// pseudo-random
        /// generator when making a Personalizer call.
        /// </summary>
        [JsonProperty(PropertyName = "eventId")]
        public string EventId { get; set; }

        /// <summary>
        /// Gets or sets send false if the user will see the rank results,
        /// therefore
        /// Personalizer will expect a Reward call, otherwise it will assign
        /// the default
        /// Reward to the event. Send true if it is possible the user will not
        /// see the
        /// rank results, because the page is rendering later, or the Rank
        /// results may be
        /// overridden by code further downstream.
        /// </summary>
        [JsonProperty(PropertyName = "deferActivation")]
        public bool? DeferActivation { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Actions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Actions");
            }
            if (Actions != null)
            {
                foreach (var element in Actions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (EventId != null)
            {
                if (EventId.Length > 256)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "EventId", 256);
                }
            }
        }
    }
}
