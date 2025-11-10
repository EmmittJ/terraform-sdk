using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsConnectInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

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
        this.WithOutput("arn");
        this.WithOutput("created_time");
        this.WithOutput("service_role");
        this.WithOutput("status");
    }

    /// <summary>
    /// The auto_resolve_best_voices_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoResolveBestVoicesEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("auto_resolve_best_voices_enabled");
        set => this.WithProperty("auto_resolve_best_voices_enabled", value);
    }

    /// <summary>
    /// The contact_flow_logs_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ContactFlowLogsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("contact_flow_logs_enabled");
        set => this.WithProperty("contact_flow_logs_enabled", value);
    }

    /// <summary>
    /// The contact_lens_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ContactLensEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("contact_lens_enabled");
        set => this.WithProperty("contact_lens_enabled", value);
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public TerraformProperty<string>? DirectoryId
    {
        get => GetProperty<TerraformProperty<string>>("directory_id");
        set => this.WithProperty("directory_id", value);
    }

    /// <summary>
    /// The early_media_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? EarlyMediaEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("early_media_enabled");
        set => this.WithProperty("early_media_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The identity_management_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityManagementType is required")]
    public required TerraformProperty<string> IdentityManagementType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("identity_management_type");
        set => this.WithProperty("identity_management_type", value);
    }

    /// <summary>
    /// The inbound_calls_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InboundCallsEnabled is required")]
    public required TerraformProperty<bool> InboundCallsEnabled
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("inbound_calls_enabled");
        set => this.WithProperty("inbound_calls_enabled", value);
    }

    /// <summary>
    /// The instance_alias attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceAlias
    {
        get => GetProperty<TerraformProperty<string>>("instance_alias");
        set => this.WithProperty("instance_alias", value);
    }

    /// <summary>
    /// The multi_party_conference_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? MultiPartyConferenceEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("multi_party_conference_enabled");
        set => this.WithProperty("multi_party_conference_enabled", value);
    }

    /// <summary>
    /// The outbound_calls_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutboundCallsEnabled is required")]
    public required TerraformProperty<bool> OutboundCallsEnabled
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("outbound_calls_enabled");
        set => this.WithProperty("outbound_calls_enabled", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsConnectInstanceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsConnectInstanceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
