using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codeconnections_connection resource.
/// </summary>
public class AwsCodeconnectionsConnection : TerraformResource
{
    public AwsCodeconnectionsConnection(string name) : base("aws_codeconnections_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("connection_status");
        this.DeclareOutput("id");
        this.DeclareOutput("owner_account_id");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The host_arn attribute.
    /// </summary>
    public TerraformProperty<string>? HostArn
    {
        get => GetProperty<TerraformProperty<string>>("host_arn");
        set => this.WithProperty("host_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The provider_type attribute.
    /// </summary>
    public TerraformProperty<string>? ProviderType
    {
        get => GetProperty<TerraformProperty<string>>("provider_type");
        set => this.WithProperty("provider_type", value);
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
    /// The connection_status attribute.
    /// </summary>
    public TerraformExpression ConnectionStatus => this["connection_status"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformExpression OwnerAccountId => this["owner_account_id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
