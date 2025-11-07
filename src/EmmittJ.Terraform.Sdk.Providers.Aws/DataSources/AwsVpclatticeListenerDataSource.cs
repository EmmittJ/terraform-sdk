using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_vpclattice_listener.
/// </summary>
public class AwsVpclatticeListenerDataSource : TerraformDataSource
{
    public AwsVpclatticeListenerDataSource(string name) : base("aws_vpclattice_listener", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_at");
        this.DeclareOutput("default_action");
        this.DeclareOutput("last_updated_at");
        this.DeclareOutput("listener_id");
        this.DeclareOutput("name");
        this.DeclareOutput("port");
        this.DeclareOutput("protocol");
        this.DeclareOutput("service_arn");
        this.DeclareOutput("service_id");
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
    /// The listener_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? ListenerIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("listener_identifier");
        set => this.WithProperty("listener_identifier", value);
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
    /// The service_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("service_identifier");
        set => this.WithProperty("service_identifier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    public TerraformExpression DefaultAction => this["default_action"];

    /// <summary>
    /// The last_updated_at attribute.
    /// </summary>
    public TerraformExpression LastUpdatedAt => this["last_updated_at"];

    /// <summary>
    /// The listener_id attribute.
    /// </summary>
    public TerraformExpression ListenerId => this["listener_id"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformExpression Port => this["port"];

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformExpression Protocol => this["protocol"];

    /// <summary>
    /// The service_arn attribute.
    /// </summary>
    public TerraformExpression ServiceArn => this["service_arn"];

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    public TerraformExpression ServiceId => this["service_id"];

}
