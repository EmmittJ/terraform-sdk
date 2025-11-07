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
    public TerraformProperty<bool>? DeletionProtectionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection_enabled");
        set => this.WithProperty("deletion_protection_enabled", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("force_destroy");
        set => this.WithProperty("force_destroy", value);
    }

    /// <summary>
    /// The kms_encryption_key attribute.
    /// </summary>
    public TerraformProperty<string>? KmsEncryptionKey
    {
        get => GetProperty<TerraformProperty<string>>("kms_encryption_key");
        set => this.WithProperty("kms_encryption_key", value);
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
