using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dsql_cluster resource.
/// </summary>
public class AwsDsqlCluster : TerraformResource
{
    public AwsDsqlCluster(string name) : base("aws_dsql_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("encryption_details");
        this.DeclareOutput("identifier");
        this.DeclareOutput("tags_all");
        this.DeclareOutput("vpc_endpoint_service_name");
    }

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    public bool? DeletionProtectionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("deletion_protection_enabled")?.Value;
        set => this.WithProperty("deletion_protection_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public bool? ForceDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_destroy")?.Value;
        set => this.WithProperty("force_destroy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The kms_encryption_key attribute.
    /// </summary>
    public string? KmsEncryptionKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_encryption_key")?.Value;
        set => this.WithProperty("kms_encryption_key", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The encryption_details attribute.
    /// </summary>
    public TerraformExpression EncryptionDetails => this["encryption_details"];

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    public TerraformExpression Identifier => this["identifier"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The vpc_endpoint_service_name attribute.
    /// </summary>
    public TerraformExpression VpcEndpointServiceName => this["vpc_endpoint_service_name"];

}
