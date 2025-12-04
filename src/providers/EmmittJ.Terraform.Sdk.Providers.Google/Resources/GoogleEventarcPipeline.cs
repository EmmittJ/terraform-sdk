using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for destinations in GoogleEventarcPipeline.
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineDestinationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destinations";

    /// <summary>
    /// The resource name of the Message Bus to which events should be
    /// published. The Message Bus resource should exist in the same project as
    /// the Pipeline. Format:
    /// &#39;projects/{project}/locations/{location}/messageBuses/{message_bus}&#39;
    /// </summary>
    public TerraformValue<string>? MessageBus
    {
        get => GetArgument<TerraformValue<string>>("message_bus");
        set => SetArgument("message_bus", value);
    }

    /// <summary>
    /// The resource name of the Pub/Sub topic to which events should be
    /// published. Format:
    /// &#39;projects/{project}/locations/{location}/topics/{topic}&#39;
    /// </summary>
    public TerraformValue<string>? Topic
    {
        get => GetArgument<TerraformValue<string>>("topic");
        set => SetArgument("topic", value);
    }

    /// <summary>
    /// The resource name of the Workflow whose Executions are triggered by
    /// the events. The Workflow resource should be deployed in the same
    /// project as the Pipeline. Format:
    /// &#39;projects/{project}/locations/{location}/workflows/{workflow}&#39;
    /// </summary>
    public TerraformValue<string>? Workflow
    {
        get => GetArgument<TerraformValue<string>>("workflow");
        set => SetArgument("workflow", value);
    }

    /// <summary>
    /// AuthenticationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticationConfig block(s) allowed")]
    public TerraformList<GoogleEventarcPipelineDestinationsBlockAuthenticationConfigBlock>? AuthenticationConfig
    {
        get => GetArgument<TerraformList<GoogleEventarcPipelineDestinationsBlockAuthenticationConfigBlock>>("authentication_config");
        set => SetArgument("authentication_config", value);
    }

    /// <summary>
    /// HttpEndpoint block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpEndpoint block(s) allowed")]
    public TerraformList<GoogleEventarcPipelineDestinationsBlockHttpEndpointBlock>? HttpEndpoint
    {
        get => GetArgument<TerraformList<GoogleEventarcPipelineDestinationsBlockHttpEndpointBlock>>("http_endpoint");
        set => SetArgument("http_endpoint", value);
    }

    /// <summary>
    /// NetworkConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    public TerraformList<GoogleEventarcPipelineDestinationsBlockNetworkConfigBlock>? NetworkConfig
    {
        get => GetArgument<TerraformList<GoogleEventarcPipelineDestinationsBlockNetworkConfigBlock>>("network_config");
        set => SetArgument("network_config", value);
    }

    /// <summary>
    /// OutputPayloadFormat block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputPayloadFormat block(s) allowed")]
    public TerraformList<GoogleEventarcPipelineDestinationsBlockOutputPayloadFormatBlock>? OutputPayloadFormat
    {
        get => GetArgument<TerraformList<GoogleEventarcPipelineDestinationsBlockOutputPayloadFormatBlock>>("output_payload_format");
        set => SetArgument("output_payload_format", value);
    }

}

/// <summary>
/// Block type for authentication_config in GoogleEventarcPipelineDestinationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineDestinationsBlockAuthenticationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authentication_config";

    /// <summary>
    /// GoogleOidc block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GoogleOidc block(s) allowed")]
    public TerraformList<GoogleEventarcPipelineDestinationsBlockAuthenticationConfigBlockGoogleOidcBlock>? GoogleOidc
    {
        get => GetArgument<TerraformList<GoogleEventarcPipelineDestinationsBlockAuthenticationConfigBlockGoogleOidcBlock>>("google_oidc");
        set => SetArgument("google_oidc", value);
    }

    /// <summary>
    /// OauthToken block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OauthToken block(s) allowed")]
    public TerraformList<GoogleEventarcPipelineDestinationsBlockAuthenticationConfigBlockOauthTokenBlock>? OauthToken
    {
        get => GetArgument<TerraformList<GoogleEventarcPipelineDestinationsBlockAuthenticationConfigBlockOauthTokenBlock>>("oauth_token");
        set => SetArgument("oauth_token", value);
    }

}

/// <summary>
/// Block type for google_oidc in GoogleEventarcPipelineDestinationsBlockAuthenticationConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineDestinationsBlockAuthenticationConfigBlockGoogleOidcBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "google_oidc";

    /// <summary>
    /// Audience to be used to generate the OIDC Token. The audience claim
    /// identifies the recipient that the JWT is intended for. If
    /// unspecified, the destination URI will be used.
    /// </summary>
    public TerraformValue<string>? Audience
    {
        get => GetArgument<TerraformValue<string>>("audience");
        set => SetArgument("audience", value);
    }

    /// <summary>
    /// Service account email used to generate the OIDC Token.
    /// The principal who calls this API must have
    /// iam.serviceAccounts.actAs permission in the service account. See
    /// https://cloud.google.com/iam/docs/understanding-service-accounts
    /// for more information. Eventarc service agents must have
    /// roles/roles/iam.serviceAccountTokenCreator role to allow the
    /// Pipeline to create OpenID tokens for authenticated requests.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccount is required")]
    public required TerraformValue<string> ServiceAccount
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_account");
        set => SetArgument("service_account", value);
    }

}

/// <summary>
/// Block type for oauth_token in GoogleEventarcPipelineDestinationsBlockAuthenticationConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineDestinationsBlockAuthenticationConfigBlockOauthTokenBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth_token";

    /// <summary>
    /// OAuth scope to be used for generating OAuth access token. If not
    /// specified, &amp;quot;https://www.googleapis.com/auth/cloud-platform&amp;quot; will be
    /// used.
    /// </summary>
    public TerraformValue<string>? Scope
    {
        get => GetArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// Service account email used to generate the [OAuth
    /// token](https://developers.google.com/identity/protocols/OAuth2).
    /// The principal who calls this API must have
    /// iam.serviceAccounts.actAs permission in the service account. See
    /// https://cloud.google.com/iam/docs/understanding-service-accounts
    /// for more information. Eventarc service agents must have
    /// roles/roles/iam.serviceAccountTokenCreator role to allow Pipeline
    /// to create OAuth2 tokens for authenticated requests.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccount is required")]
    public required TerraformValue<string> ServiceAccount
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_account");
        set => SetArgument("service_account", value);
    }

}

/// <summary>
/// Block type for http_endpoint in GoogleEventarcPipelineDestinationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineDestinationsBlockHttpEndpointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_endpoint";

    /// <summary>
    /// The CEL expression used to modify how the destination-bound HTTP
    /// request is constructed.
    /// 
    /// If a binding expression is not specified here, the message
    /// is treated as a CloudEvent and is mapped to the HTTP request according
    /// to the CloudEvent HTTP Protocol Binding Binary Content Mode
    /// (https://github.com/cloudevents/spec/blob/main/cloudevents/bindings/http-protocol-binding.md#31-binary-content-mode).
    /// In this representation, all fields except the &#39;data&#39; and
    /// &#39;datacontenttype&#39; field on the message are mapped to HTTP request
    /// headers with a prefix of &#39;ce-&#39;.
    /// 
    /// To construct the HTTP request payload and the value of the content-type
    /// HTTP header, the payload format is defined as follows:
    /// 1) Use the output_payload_format_type on the Pipeline.Destination if it
    /// is set, else:
    /// 2) Use the input_payload_format_type on the Pipeline if it is set,
    /// else:
    /// 3) Treat the payload as opaque binary data.
    /// 
    /// The &#39;data&#39; field of the message is converted to the payload format or
    /// left as-is for case 3) and then attached as the payload of the HTTP
    /// request. The &#39;content-type&#39; header on the HTTP request is set to the
    /// payload format type or left empty for case 3). However, if a mediation
    /// has updated the &#39;datacontenttype&#39; field on the message so that it is
    /// not the same as the payload format type but it is still a prefix of the
    /// payload format type, then the &#39;content-type&#39; header on the HTTP request
    /// is set to this &#39;datacontenttype&#39; value. For example, if the
    /// &#39;datacontenttype&#39; is &amp;quot;application/json&amp;quot; and the payload format type is
    /// &amp;quot;application/json; charset=utf-8&amp;quot;, then the &#39;content-type&#39; header on
    /// the HTTP request is set to &amp;quot;application/json; charset=utf-8&amp;quot;.
    /// 
    /// If a non-empty binding expression is specified then this expression is
    /// used to modify the default CloudEvent HTTP Protocol Binding Binary
    /// Content representation.
    /// The result of the CEL expression must be a map of key/value pairs
    /// which is used as follows:
    /// - If a map named &#39;headers&#39; exists on the result of the expression,
    /// then its key/value pairs are directly mapped to the HTTP request
    /// headers. The headers values are constructed from the corresponding
    /// value type&#39;s canonical representation. If the &#39;headers&#39; field doesn&#39;t
    /// exist then the resulting HTTP request will be the headers of the
    /// CloudEvent HTTP Binding Binary Content Mode representation of the final
    /// message. Note: If the specified binding expression, has updated the
    /// &#39;datacontenttype&#39; field on the message so that it is not the same as
    /// the payload format type but it is still a prefix of the payload format
    /// type, then the &#39;content-type&#39; header in the &#39;headers&#39; map is set to
    /// this &#39;datacontenttype&#39; value.
    /// - If a field named &#39;body&#39; exists on the result of the expression then
    /// its value is directly mapped to the body of the request. If the value
    /// of the &#39;body&#39; field is of type bytes or string then it is used for
    /// the HTTP request body as-is, with no conversion. If the body field is
    /// of any other type then it is converted to a JSON string. If the body
    /// field does not exist then the resulting payload of the HTTP request
    /// will be data value of the CloudEvent HTTP Binding Binary Content Mode
    /// representation of the final message as described earlier.
    /// - Any other fields in the resulting expression will be ignored.
    /// 
    /// The CEL expression may access the incoming CloudEvent message in its
    /// definition, as follows:
    /// - The &#39;data&#39; field of the incoming CloudEvent message can be accessed
    /// using the &#39;message.data&#39; value. Subfields of &#39;message.data&#39; may also be
    /// accessed if an input_payload_format has been specified on the Pipeline.
    /// - Each attribute of the incoming CloudEvent message can be accessed
    /// using the &#39;message.&#39; value, where  is replaced with the
    /// name of the attribute.
    /// - Existing headers can be accessed in the CEL expression using the
    /// &#39;headers&#39; variable. The &#39;headers&#39; variable defines a map of key/value
    /// pairs corresponding to the HTTP headers of the CloudEvent HTTP Binding
    /// Binary Content Mode representation of the final message as described
    /// earlier. For example, the following CEL expression can be used to
    /// construct an HTTP request by adding an additional header to the HTTP
    /// headers of the CloudEvent HTTP Binding Binary Content Mode
    /// representation of the final message and by overwriting the body of the
    /// request:
    /// 
    /// &#39;&#39;&#39;
    /// {
    /// &amp;quot;headers&amp;quot;: headers.merge({&amp;quot;new-header-key&amp;quot;: &amp;quot;new-header-value&amp;quot;}),
    /// &amp;quot;body&amp;quot;: &amp;quot;new-body&amp;quot;
    /// }
    /// &#39;&#39;&#39;
    /// - The default binding for the message payload can be accessed using the
    /// &#39;body&#39; variable. It conatins a string representation of the message
    /// payload in the format specified by the &#39;output_payload_format&#39; field.
    /// If the &#39;input_payload_format&#39; field is not set, the &#39;body&#39;
    /// variable contains the same message payload bytes that were published.
    /// 
    /// Additionally, the following CEL extension functions are provided for
    /// use in this CEL expression:
    /// - toBase64Url:
    /// map.toBase64Url() -&amp;gt; string
    /// - Converts a CelValue to a base64url encoded string
    /// - toJsonString: map.toJsonString() -&amp;gt; string
    /// - Converts a CelValue to a JSON string
    /// - merge:
    /// map1.merge(map2) -&amp;gt; map3
    /// - Merges the passed CEL map with the existing CEL map the
    /// function is applied to.
    /// - If the same key exists in both maps, if the key&#39;s value is type
    /// map both maps are merged else the value from the passed map is
    /// used.
    /// - denormalize:
    /// map.denormalize() -&amp;gt; map
    /// - Denormalizes a CEL map such that every value of type map or key
    /// in the map is expanded to return a single level map.
    /// - The resulting keys are &amp;quot;.&amp;quot; separated indices of the map keys.
    /// - For example:
    /// {
    /// &amp;quot;a&amp;quot;: 1,
    /// &amp;quot;b&amp;quot;: {
    /// &amp;quot;c&amp;quot;: 2,
    /// &amp;quot;d&amp;quot;: 3
    /// }
    /// &amp;quot;e&amp;quot;: [4, 5]
    /// }
    /// .denormalize()
    /// -&amp;gt; {
    /// &amp;quot;a&amp;quot;: 1,
    /// &amp;quot;b.c&amp;quot;: 2,
    /// &amp;quot;b.d&amp;quot;: 3,
    /// &amp;quot;e.0&amp;quot;: 4,
    /// &amp;quot;e.1&amp;quot;: 5
    /// }
    /// - setField:
    /// map.setField(key, value) -&amp;gt; message
    /// - Sets the field of the message with the given key to the
    /// given value.
    /// - If the field is not present it will be added.
    /// - If the field is present it will be overwritten.
    /// - The key can be a dot separated path to set a field in a nested
    /// message.
    /// - Key must be of type string.
    /// - Value may be any valid type.
    /// - removeFields:
    /// map.removeFields([key1, key2, ...]) -&amp;gt; message
    /// - Removes the fields of the map with the given keys.
    /// - The keys can be a dot separated path to remove a field in a
    /// nested message.
    /// - If a key is not found it will be ignored.
    /// - Keys must be of type string.
    /// - toMap:
    /// [map1, map2, ...].toMap() -&amp;gt; map
    /// - Converts a CEL list of CEL maps to a single CEL map
    /// - toCloudEventJsonWithPayloadFormat:
    /// message.toCloudEventJsonWithPayloadFormat() -&amp;gt; map
    /// - Converts a message to the corresponding structure of JSON
    /// format for CloudEvents.
    /// - It converts &#39;data&#39; to destination payload format
    /// specified in &#39;output_payload_format&#39;. If &#39;output_payload_format&#39; is
    /// not set, the data will remain unchanged.
    /// - It also sets the corresponding datacontenttype of
    /// the CloudEvent, as indicated by
    /// &#39;output_payload_format&#39;. If no
    /// &#39;output_payload_format&#39; is set it will use the value of the
    /// &amp;quot;datacontenttype&amp;quot; attribute on the CloudEvent if present, else
    /// remove &amp;quot;datacontenttype&amp;quot; attribute.
    /// - This function expects that the content of the message will
    /// adhere to the standard CloudEvent format. If it doesn&#39;t then this
    /// function will fail.
    /// - The result is a CEL map that corresponds to the JSON
    /// representation of the CloudEvent. To convert that data to a JSON
    /// string it can be chained with the toJsonString function.
    /// 
    /// The Pipeline expects that the message it receives adheres to the
    /// standard CloudEvent format. If it doesn&#39;t then the outgoing message
    /// request may fail with a persistent error.
    /// </summary>
    public TerraformValue<string>? MessageBindingTemplate
    {
        get => GetArgument<TerraformValue<string>>("message_binding_template");
        set => SetArgument("message_binding_template", value);
    }

    /// <summary>
    /// The URI of the HTTP enpdoint.
    /// 
    /// The value must be a RFC2396 URI string.
    /// Examples: &#39;https://svc.us-central1.p.local:8080/route&#39;.
    /// Only the HTTPS protocol is supported.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetRequiredArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for network_config in GoogleEventarcPipelineDestinationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineDestinationsBlockNetworkConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_config";

    /// <summary>
    /// Name of the NetworkAttachment that allows access to the consumer VPC.
    /// 
    /// Format:
    /// &#39;projects/{PROJECT_ID}/regions/{REGION}/networkAttachments/{NETWORK_ATTACHMENT_NAME}&#39;
    /// 
    /// Required for HTTP endpoint destinations. Must not be specified for
    /// Workflows, MessageBus, or Topic destinations.
    /// </summary>
    public TerraformValue<string>? NetworkAttachment
    {
        get => GetArgument<TerraformValue<string>>("network_attachment");
        set => SetArgument("network_attachment", value);
    }

}

/// <summary>
/// Block type for output_payload_format in GoogleEventarcPipelineDestinationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineDestinationsBlockOutputPayloadFormatBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_payload_format";

    /// <summary>
    /// Avro block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Avro block(s) allowed")]
    public TerraformList<GoogleEventarcPipelineDestinationsBlockOutputPayloadFormatBlockAvroBlock>? Avro
    {
        get => GetArgument<TerraformList<GoogleEventarcPipelineDestinationsBlockOutputPayloadFormatBlockAvroBlock>>("avro");
        set => SetArgument("avro", value);
    }

    /// <summary>
    /// Json block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Json block(s) allowed")]
    public TerraformList<GoogleEventarcPipelineDestinationsBlockOutputPayloadFormatBlockJsonBlock>? Json
    {
        get => GetArgument<TerraformList<GoogleEventarcPipelineDestinationsBlockOutputPayloadFormatBlockJsonBlock>>("json");
        set => SetArgument("json", value);
    }

    /// <summary>
    /// Protobuf block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Protobuf block(s) allowed")]
    public TerraformList<GoogleEventarcPipelineDestinationsBlockOutputPayloadFormatBlockProtobufBlock>? Protobuf
    {
        get => GetArgument<TerraformList<GoogleEventarcPipelineDestinationsBlockOutputPayloadFormatBlockProtobufBlock>>("protobuf");
        set => SetArgument("protobuf", value);
    }

}

/// <summary>
/// Block type for avro in GoogleEventarcPipelineDestinationsBlockOutputPayloadFormatBlock.
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineDestinationsBlockOutputPayloadFormatBlockAvroBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "avro";

    /// <summary>
    /// The entire schema definition is stored in this field.
    /// </summary>
    public TerraformValue<string>? SchemaDefinition
    {
        get => GetArgument<TerraformValue<string>>("schema_definition");
        set => SetArgument("schema_definition", value);
    }

}

/// <summary>
/// Block type for json in GoogleEventarcPipelineDestinationsBlockOutputPayloadFormatBlock.
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineDestinationsBlockOutputPayloadFormatBlockJsonBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "json";

}

/// <summary>
/// Block type for protobuf in GoogleEventarcPipelineDestinationsBlockOutputPayloadFormatBlock.
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineDestinationsBlockOutputPayloadFormatBlockProtobufBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "protobuf";

    /// <summary>
    /// The entire schema definition is stored in this field.
    /// </summary>
    public TerraformValue<string>? SchemaDefinition
    {
        get => GetArgument<TerraformValue<string>>("schema_definition");
        set => SetArgument("schema_definition", value);
    }

}


/// <summary>
/// Block type for input_payload_format in GoogleEventarcPipeline.
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineInputPayloadFormatBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_payload_format";

    /// <summary>
    /// Avro block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Avro block(s) allowed")]
    public TerraformList<GoogleEventarcPipelineInputPayloadFormatBlockAvroBlock>? Avro
    {
        get => GetArgument<TerraformList<GoogleEventarcPipelineInputPayloadFormatBlockAvroBlock>>("avro");
        set => SetArgument("avro", value);
    }

    /// <summary>
    /// Json block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Json block(s) allowed")]
    public TerraformList<GoogleEventarcPipelineInputPayloadFormatBlockJsonBlock>? Json
    {
        get => GetArgument<TerraformList<GoogleEventarcPipelineInputPayloadFormatBlockJsonBlock>>("json");
        set => SetArgument("json", value);
    }

    /// <summary>
    /// Protobuf block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Protobuf block(s) allowed")]
    public TerraformList<GoogleEventarcPipelineInputPayloadFormatBlockProtobufBlock>? Protobuf
    {
        get => GetArgument<TerraformList<GoogleEventarcPipelineInputPayloadFormatBlockProtobufBlock>>("protobuf");
        set => SetArgument("protobuf", value);
    }

}

/// <summary>
/// Block type for avro in GoogleEventarcPipelineInputPayloadFormatBlock.
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineInputPayloadFormatBlockAvroBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "avro";

    /// <summary>
    /// The entire schema definition is stored in this field.
    /// </summary>
    public TerraformValue<string>? SchemaDefinition
    {
        get => GetArgument<TerraformValue<string>>("schema_definition");
        set => SetArgument("schema_definition", value);
    }

}

/// <summary>
/// Block type for json in GoogleEventarcPipelineInputPayloadFormatBlock.
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineInputPayloadFormatBlockJsonBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "json";

}

/// <summary>
/// Block type for protobuf in GoogleEventarcPipelineInputPayloadFormatBlock.
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineInputPayloadFormatBlockProtobufBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "protobuf";

    /// <summary>
    /// The entire schema definition is stored in this field.
    /// </summary>
    public TerraformValue<string>? SchemaDefinition
    {
        get => GetArgument<TerraformValue<string>>("schema_definition");
        set => SetArgument("schema_definition", value);
    }

}


/// <summary>
/// Block type for logging_config in GoogleEventarcPipeline.
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_config";

    /// <summary>
    /// The minimum severity of logs that will be sent to Stackdriver/Platform
    /// Telemetry. Logs at severitiy ≥ this value will be sent, unless it is NONE. Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;DEBUG&amp;quot;, &amp;quot;INFO&amp;quot;, &amp;quot;NOTICE&amp;quot;, &amp;quot;WARNING&amp;quot;, &amp;quot;ERROR&amp;quot;, &amp;quot;CRITICAL&amp;quot;, &amp;quot;ALERT&amp;quot;, &amp;quot;EMERGENCY&amp;quot;]
    /// </summary>
    public TerraformValue<string> LogSeverity
    {
        get => GetArgument<TerraformValue<string>>("log_severity") ?? AsReference("log_severity");
        set => SetArgument("log_severity", value);
    }

}


/// <summary>
/// Block type for mediations in GoogleEventarcPipeline.
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineMediationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mediations";

    /// <summary>
    /// Transformation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Transformation block(s) allowed")]
    public TerraformList<GoogleEventarcPipelineMediationsBlockTransformationBlock>? Transformation
    {
        get => GetArgument<TerraformList<GoogleEventarcPipelineMediationsBlockTransformationBlock>>("transformation");
        set => SetArgument("transformation", value);
    }

}

/// <summary>
/// Block type for transformation in GoogleEventarcPipelineMediationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineMediationsBlockTransformationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transformation";

    /// <summary>
    /// The CEL expression template to apply to transform messages.
    /// The following CEL extension functions are provided for
    /// use in this CEL expression:
    /// - merge:
    /// map1.merge(map2) -&amp;gt; map3
    /// - Merges the passed CEL map with the existing CEL map the
    /// function is applied to.
    /// - If the same key exists in both maps, if the key&#39;s value is type
    /// map both maps are merged else the value from the passed map is
    /// used.
    /// - denormalize:
    /// map.denormalize() -&amp;gt; map
    /// - Denormalizes a CEL map such that every value of type map or key
    /// in the map is expanded to return a single level map.
    /// - The resulting keys are &amp;quot;.&amp;quot; separated indices of the map keys.
    /// - For example:
    /// {
    /// &amp;quot;a&amp;quot;: 1,
    /// &amp;quot;b&amp;quot;: {
    /// &amp;quot;c&amp;quot;: 2,
    /// &amp;quot;d&amp;quot;: 3
    /// }
    /// &amp;quot;e&amp;quot;: [4, 5]
    /// }
    /// .denormalize()
    /// -&amp;gt; {
    /// &amp;quot;a&amp;quot;: 1,
    /// &amp;quot;b.c&amp;quot;: 2,
    /// &amp;quot;b.d&amp;quot;: 3,
    /// &amp;quot;e.0&amp;quot;: 4,
    /// &amp;quot;e.1&amp;quot;: 5
    /// }
    /// - setField:
    /// map.setField(key, value) -&amp;gt; message
    /// - Sets the field of the message with the given key to the
    /// given value.
    /// - If the field is not present it will be added.
    /// - If the field is present it will be overwritten.
    /// - The key can be a dot separated path to set a field in a nested
    /// message.
    /// - Key must be of type string.
    /// - Value may be any valid type.
    /// - removeFields:
    /// map.removeFields([key1, key2, ...]) -&amp;gt; message
    /// - Removes the fields of the map with the given keys.
    /// - The keys can be a dot separated path to remove a field in a
    /// nested message.
    /// - If a key is not found it will be ignored.
    /// - Keys must be of type string.
    /// - toMap:
    /// [map1, map2, ...].toMap() -&amp;gt; map
    /// - Converts a CEL list of CEL maps to a single CEL map
    /// - toDestinationPayloadFormat():
    /// message.data.toDestinationPayloadFormat() -&amp;gt; string or bytes
    /// - Converts the message data to the destination payload format
    /// specified in Pipeline.Destination.output_payload_format
    /// - This function is meant to be applied to the message.data field.
    /// - If the destination payload format is not set, the function will
    /// return the message data unchanged.
    /// - toCloudEventJsonWithPayloadFormat:
    /// message.toCloudEventJsonWithPayloadFormat() -&amp;gt; map
    /// - Converts a message to the corresponding structure of JSON
    /// format for CloudEvents
    /// - This function applies toDestinationPayloadFormat() to the
    /// message data. It also sets the corresponding datacontenttype of
    /// the CloudEvent, as indicated by
    /// Pipeline.Destination.output_payload_format. If no
    /// output_payload_format is set it will use the existing
    /// datacontenttype on the CloudEvent if present, else leave
    /// datacontenttype absent.
    /// - This function expects that the content of the message will
    /// adhere to the standard CloudEvent format. If it doesn&#39;t then this
    /// function will fail.
    /// - The result is a CEL map that corresponds to the JSON
    /// representation of the CloudEvent. To convert that data to a JSON
    /// string it can be chained with the toJsonString function.
    /// </summary>
    public TerraformValue<string>? TransformationTemplate
    {
        get => GetArgument<TerraformValue<string>>("transformation_template");
        set => SetArgument("transformation_template", value);
    }

}


/// <summary>
/// Block type for retry_policy in GoogleEventarcPipeline.
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineRetryPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retry_policy";

    /// <summary>
    /// The maximum number of delivery attempts for any message. The value must
    /// be between 1 and 100.
    /// The default value for this field is 5.
    /// </summary>
    public TerraformValue<double>? MaxAttempts
    {
        get => GetArgument<TerraformValue<double>>("max_attempts");
        set => SetArgument("max_attempts", value);
    }

    /// <summary>
    /// The maximum amount of seconds to wait between retry attempts. The value
    /// must be between 1 and 600.
    /// The default value for this field is 60.
    /// </summary>
    public TerraformValue<string>? MaxRetryDelay
    {
        get => GetArgument<TerraformValue<string>>("max_retry_delay");
        set => SetArgument("max_retry_delay", value);
    }

    /// <summary>
    /// The minimum amount of seconds to wait between retry attempts. The value
    /// must be between 1 and 600.
    /// The default value for this field is 5.
    /// </summary>
    public TerraformValue<string>? MinRetryDelay
    {
        get => GetArgument<TerraformValue<string>>("min_retry_delay");
        set => SetArgument("min_retry_delay", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleEventarcPipeline.
/// Nesting mode: single
/// </summary>
public class GoogleEventarcPipelineTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_eventarc_pipeline Terraform resource.
/// Manages a google_eventarc_pipeline resource.
/// </summary>
public partial class GoogleEventarcPipeline(string name) : TerraformResource("google_eventarc_pipeline", name)
{
    /// <summary>
    /// User-defined annotations. See https://google.aip.dev/128#annotations.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => GetArgument<TerraformMap<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// Resource name of a KMS crypto key (managed by the user) used to
    /// encrypt/decrypt the event data. If not set, an internal Google-owned key
    /// will be used to encrypt messages. It must match the pattern
    /// &amp;quot;projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}&amp;quot;.
    /// </summary>
    public TerraformValue<string>? CryptoKeyName
    {
        get => GetArgument<TerraformValue<string>>("crypto_key_name");
        set => SetArgument("crypto_key_name", value);
    }

    /// <summary>
    /// Display name of resource.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// User labels attached to the Pipeline that can be used to group
    /// resources. An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: {
    /// &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The user-provided ID to be assigned to the Pipeline. It should match the
    /// format &#39;^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineId is required")]
    public required TerraformValue<string> PipelineId
    {
        get => GetRequiredArgument<TerraformValue<string>>("pipeline_id");
        set => SetArgument("pipeline_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The creation time.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up
    /// to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and
    /// &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
        => AsReference("effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// This checksum is computed by the server based on the value of
    /// other fields, and might be sent only on create requests to ensure that the
    /// client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// The resource name of the Pipeline. Must be unique within the
    /// location of the project and must be in
    /// &#39;projects/{project}/locations/{location}/pipelines/{pipeline}&#39; format.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Server-assigned unique identifier for the Pipeline. The value
    /// is a UUID4 string and guaranteed to remain unchanged until the resource is
    /// deleted.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// The last-modified time.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up
    /// to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and
    /// &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Destinations block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destinations is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destinations block(s) required")]
    public required TerraformList<GoogleEventarcPipelineDestinationsBlock> Destinations
    {
        get => GetRequiredArgument<TerraformList<GoogleEventarcPipelineDestinationsBlock>>("destinations");
        set => SetArgument("destinations", value);
    }

    /// <summary>
    /// InputPayloadFormat block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputPayloadFormat block(s) allowed")]
    public TerraformList<GoogleEventarcPipelineInputPayloadFormatBlock>? InputPayloadFormat
    {
        get => GetArgument<TerraformList<GoogleEventarcPipelineInputPayloadFormatBlock>>("input_payload_format");
        set => SetArgument("input_payload_format", value);
    }

    /// <summary>
    /// LoggingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public TerraformList<GoogleEventarcPipelineLoggingConfigBlock>? LoggingConfig
    {
        get => GetArgument<TerraformList<GoogleEventarcPipelineLoggingConfigBlock>>("logging_config");
        set => SetArgument("logging_config", value);
    }

    /// <summary>
    /// Mediations block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleEventarcPipelineMediationsBlock>? Mediations
    {
        get => GetArgument<TerraformList<GoogleEventarcPipelineMediationsBlock>>("mediations");
        set => SetArgument("mediations", value);
    }

    /// <summary>
    /// RetryPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    public TerraformList<GoogleEventarcPipelineRetryPolicyBlock>? RetryPolicy
    {
        get => GetArgument<TerraformList<GoogleEventarcPipelineRetryPolicyBlock>>("retry_policy");
        set => SetArgument("retry_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleEventarcPipelineTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleEventarcPipelineTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
