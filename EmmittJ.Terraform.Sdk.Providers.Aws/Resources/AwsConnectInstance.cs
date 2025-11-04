using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_connect_instance resource.
/// </summary>
public class AwsConnectInstance : TerraformResource
{
    public AwsConnectInstance(string name) : base("aws_connect_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_time");
        this.DeclareOutput("service_role");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The auto_resolve_best_voices_enabled attribute.
    /// </summary>
    public bool? AutoResolveBestVoicesEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_resolve_best_voices_enabled")?.Value;
        set => this.WithProperty("auto_resolve_best_voices_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The contact_flow_logs_enabled attribute.
    /// </summary>
    public bool? ContactFlowLogsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("contact_flow_logs_enabled")?.Value;
        set => this.WithProperty("contact_flow_logs_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The contact_lens_enabled attribute.
    /// </summary>
    public bool? ContactLensEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("contact_lens_enabled")?.Value;
        set => this.WithProperty("contact_lens_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public string? DirectoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("directory_id")?.Value;
        set => this.WithProperty("directory_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The early_media_enabled attribute.
    /// </summary>
    public bool? EarlyMediaEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("early_media_enabled")?.Value;
        set => this.WithProperty("early_media_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The identity_management_type attribute.
    /// </summary>
    public string? IdentityManagementType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_management_type")?.Value;
        set => this.WithProperty("identity_management_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The inbound_calls_enabled attribute.
    /// </summary>
    public bool? InboundCallsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("inbound_calls_enabled")?.Value;
        set => this.WithProperty("inbound_calls_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The instance_alias attribute.
    /// </summary>
    public string? InstanceAlias
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_alias")?.Value;
        set => this.WithProperty("instance_alias", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The multi_party_conference_enabled attribute.
    /// </summary>
    public bool? MultiPartyConferenceEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("multi_party_conference_enabled")?.Value;
        set => this.WithProperty("multi_party_conference_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The outbound_calls_enabled attribute.
    /// </summary>
    public bool? OutboundCallsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("outbound_calls_enabled")?.Value;
        set => this.WithProperty("outbound_calls_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformExpression CreatedTime => this["created_time"];

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    public TerraformExpression ServiceRole => this["service_role"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
