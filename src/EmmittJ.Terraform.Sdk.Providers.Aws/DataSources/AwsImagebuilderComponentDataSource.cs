using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_imagebuilder_component.
/// </summary>
public class AwsImagebuilderComponentDataSource : TerraformDataSource
{
    public AwsImagebuilderComponentDataSource(string name) : base("aws_imagebuilder_component", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("change_description");
        this.DeclareOutput("data");
        this.DeclareOutput("date_created");
        this.DeclareOutput("description");
        this.DeclareOutput("encrypted");
        this.DeclareOutput("kms_key_id");
        this.DeclareOutput("name");
        this.DeclareOutput("owner");
        this.DeclareOutput("platform");
        this.DeclareOutput("supported_os_versions");
        this.DeclareOutput("type");
        this.DeclareOutput("version");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string>? Arn
    {
        get => GetProperty<TerraformProperty<string>>("arn");
        set => this.WithProperty("arn", value);
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
    /// The change_description attribute.
    /// </summary>
    public TerraformExpression ChangeDescription => this["change_description"];

    /// <summary>
    /// The data attribute.
    /// </summary>
    public TerraformExpression Data => this["data"];

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    public TerraformExpression DateCreated => this["date_created"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformExpression Encrypted => this["encrypted"];

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformExpression KmsKeyId => this["kms_key_id"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformExpression Owner => this["owner"];

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformExpression Platform => this["platform"];

    /// <summary>
    /// The supported_os_versions attribute.
    /// </summary>
    public TerraformExpression SupportedOsVersions => this["supported_os_versions"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
