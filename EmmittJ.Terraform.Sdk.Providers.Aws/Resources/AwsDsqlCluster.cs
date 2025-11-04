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
    /// The kms_encryption_key attribute.
    /// </summary>
    public string? KmsEncryptionKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_encryption_key")?.Value;
        set => this.WithProperty("kms_encryption_key", value == null ? null : new TerraformLiteralProperty<string>(value));
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
