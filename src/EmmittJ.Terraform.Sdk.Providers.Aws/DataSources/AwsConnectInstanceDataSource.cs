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
        this.DeclareOutput("arn");
        this.DeclareOutput("auto_resolve_best_voices_enabled");
        this.DeclareOutput("contact_flow_logs_enabled");
        this.DeclareOutput("contact_lens_enabled");
        this.DeclareOutput("created_time");
        this.DeclareOutput("early_media_enabled");
        this.DeclareOutput("identity_management_type");
        this.DeclareOutput("inbound_calls_enabled");
        this.DeclareOutput("multi_party_conference_enabled");
        this.DeclareOutput("outbound_calls_enabled");
        this.DeclareOutput("service_role");
        this.DeclareOutput("status");
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
    /// The instance_alias attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceAlias
    {
        get => GetProperty<TerraformProperty<string>>("instance_alias");
        set => this.WithProperty("instance_alias", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceId
    {
        get => GetProperty<TerraformProperty<string>>("instance_id");
        set => this.WithProperty("instance_id", value);
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
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
