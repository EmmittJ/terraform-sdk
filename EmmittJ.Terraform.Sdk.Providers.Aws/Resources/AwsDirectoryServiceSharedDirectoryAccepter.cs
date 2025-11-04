using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_directory_service_shared_directory_accepter resource.
/// </summary>
public class AwsDirectoryServiceSharedDirectoryAccepter : TerraformResource
{
    public AwsDirectoryServiceSharedDirectoryAccepter(string name) : base("aws_directory_service_shared_directory_accepter", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("method");
        this.DeclareOutput("notes");
        this.DeclareOutput("owner_account_id");
        this.DeclareOutput("owner_directory_id");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The shared_directory_id attribute.
    /// </summary>
    public string? SharedDirectoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("shared_directory_id")?.Value;
        set => this.WithProperty("shared_directory_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The method attribute.
    /// </summary>
    public TerraformExpression Method => this["method"];

    /// <summary>
    /// The notes attribute.
    /// </summary>
    public TerraformExpression Notes => this["notes"];

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformExpression OwnerAccountId => this["owner_account_id"];

    /// <summary>
    /// The owner_directory_id attribute.
    /// </summary>
    public TerraformExpression OwnerDirectoryId => this["owner_directory_id"];

}
