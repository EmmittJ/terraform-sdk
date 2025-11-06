using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_endpoint_authorization resource.
/// </summary>
public class AwsRedshiftEndpointAuthorization : TerraformResource
{
    public AwsRedshiftEndpointAuthorization(string name) : base("aws_redshift_endpoint_authorization", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("allowed_all_vpcs");
        this.DeclareOutput("endpoint_count");
        this.DeclareOutput("grantee");
        this.DeclareOutput("grantor");
    }

    /// <summary>
    /// The account attribute.
    /// </summary>
    public string? Account
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account")?.Value;
        set => this.WithProperty("account", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public string? ClusterIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_identifier")?.Value;
        set => this.WithProperty("cluster_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    public bool? ForceDelete
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_delete")?.Value;
        set => this.WithProperty("force_delete", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The vpc_ids attribute.
    /// </summary>
    public HashSet<string>? VpcIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("vpc_ids")?.Value;
        set => this.WithProperty("vpc_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The allowed_all_vpcs attribute.
    /// </summary>
    public TerraformExpression AllowedAllVpcs => this["allowed_all_vpcs"];

    /// <summary>
    /// The endpoint_count attribute.
    /// </summary>
    public TerraformExpression EndpointCount => this["endpoint_count"];

    /// <summary>
    /// The grantee attribute.
    /// </summary>
    public TerraformExpression Grantee => this["grantee"];

    /// <summary>
    /// The grantor attribute.
    /// </summary>
    public TerraformExpression Grantor => this["grantor"];

}
