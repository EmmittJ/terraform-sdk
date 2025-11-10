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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
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
        SetOutput("arn");
        SetOutput("created_time");
        SetOutput("service_role");
        SetOutput("status");
        SetOutput("auto_resolve_best_voices_enabled");
        SetOutput("contact_flow_logs_enabled");
        SetOutput("contact_lens_enabled");
        SetOutput("directory_id");
        SetOutput("early_media_enabled");
        SetOutput("id");
        SetOutput("identity_management_type");
        SetOutput("inbound_calls_enabled");
        SetOutput("instance_alias");
        SetOutput("multi_party_conference_enabled");
        SetOutput("outbound_calls_enabled");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The auto_resolve_best_voices_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AutoResolveBestVoicesEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_resolve_best_voices_enabled");
        set => SetProperty("auto_resolve_best_voices_enabled", value);
    }

    /// <summary>
    /// The contact_flow_logs_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ContactFlowLogsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("contact_flow_logs_enabled");
        set => SetProperty("contact_flow_logs_enabled", value);
    }

    /// <summary>
    /// The contact_lens_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ContactLensEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("contact_lens_enabled");
        set => SetProperty("contact_lens_enabled", value);
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public TerraformProperty<string> DirectoryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("directory_id");
        set => SetProperty("directory_id", value);
    }

    /// <summary>
    /// The early_media_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> EarlyMediaEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("early_media_enabled");
        set => SetProperty("early_media_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The identity_management_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityManagementType is required")]
    public required TerraformProperty<string> IdentityManagementType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity_management_type");
        set => SetProperty("identity_management_type", value);
    }

    /// <summary>
    /// The inbound_calls_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InboundCallsEnabled is required")]
    public required TerraformProperty<bool> InboundCallsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("inbound_calls_enabled");
        set => SetProperty("inbound_calls_enabled", value);
    }

    /// <summary>
    /// The instance_alias attribute.
    /// </summary>
    public TerraformProperty<string> InstanceAlias
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_alias");
        set => SetProperty("instance_alias", value);
    }

    /// <summary>
    /// The multi_party_conference_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> MultiPartyConferenceEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("multi_party_conference_enabled");
        set => SetProperty("multi_party_conference_enabled", value);
    }

    /// <summary>
    /// The outbound_calls_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutboundCallsEnabled is required")]
    public required TerraformProperty<bool> OutboundCallsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("outbound_calls_enabled");
        set => SetProperty("outbound_calls_enabled", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsConnectInstanceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
