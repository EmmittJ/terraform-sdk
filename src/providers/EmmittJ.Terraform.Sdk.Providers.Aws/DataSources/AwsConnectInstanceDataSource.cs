using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_connect_instance.
/// </summary>
public class AwsConnectInstanceDataSource : TerraformDataSource
{
    public AwsConnectInstanceDataSource(string name) : base("aws_connect_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("auto_resolve_best_voices_enabled");
        SetOutput("contact_flow_logs_enabled");
        SetOutput("contact_lens_enabled");
        SetOutput("created_time");
        SetOutput("early_media_enabled");
        SetOutput("identity_management_type");
        SetOutput("inbound_calls_enabled");
        SetOutput("multi_party_conference_enabled");
        SetOutput("outbound_calls_enabled");
        SetOutput("service_role");
        SetOutput("status");
        SetOutput("id");
        SetOutput("instance_alias");
        SetOutput("instance_id");
        SetOutput("region");
        SetOutput("tags");
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
    /// The instance_alias attribute.
    /// </summary>
    public TerraformProperty<string> InstanceAlias
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_alias");
        set => SetProperty("instance_alias", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    public TerraformProperty<string> InstanceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_id");
        set => SetProperty("instance_id", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The auto_resolve_best_voices_enabled attribute.
    /// </summary>
    public TerraformExpression AutoResolveBestVoicesEnabled => this["auto_resolve_best_voices_enabled"];

    /// <summary>
    /// The contact_flow_logs_enabled attribute.
    /// </summary>
    public TerraformExpression ContactFlowLogsEnabled => this["contact_flow_logs_enabled"];

    /// <summary>
    /// The contact_lens_enabled attribute.
    /// </summary>
    public TerraformExpression ContactLensEnabled => this["contact_lens_enabled"];

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformExpression CreatedTime => this["created_time"];

    /// <summary>
    /// The early_media_enabled attribute.
    /// </summary>
    public TerraformExpression EarlyMediaEnabled => this["early_media_enabled"];

    /// <summary>
    /// The identity_management_type attribute.
    /// </summary>
    public TerraformExpression IdentityManagementType => this["identity_management_type"];

    /// <summary>
    /// The inbound_calls_enabled attribute.
    /// </summary>
    public TerraformExpression InboundCallsEnabled => this["inbound_calls_enabled"];

    /// <summary>
    /// The multi_party_conference_enabled attribute.
    /// </summary>
    public TerraformExpression MultiPartyConferenceEnabled => this["multi_party_conference_enabled"];

    /// <summary>
    /// The outbound_calls_enabled attribute.
    /// </summary>
    public TerraformExpression OutboundCallsEnabled => this["outbound_calls_enabled"];

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    public TerraformExpression ServiceRole => this["service_role"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
