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
    public TerraformProperty<string>? Account
    {
        get => GetProperty<TerraformProperty<string>>("account");
        set => this.WithProperty("account", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("cluster_identifier");
        set => this.WithProperty("cluster_identifier", value);
    }

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceDelete
    {
        get => GetProperty<TerraformProperty<bool>>("force_delete");
        set => this.WithProperty("force_delete", value);
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
    /// The vpc_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? VpcIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("vpc_ids");
        set => this.WithProperty("vpc_ids", value);
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
