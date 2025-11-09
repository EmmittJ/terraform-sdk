using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_eks_pod_identity_association resource.
/// </summary>
public class AwsEksPodIdentityAssociation : TerraformResource
{
    public AwsEksPodIdentityAssociation(string name) : base("aws_eks_pod_identity_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("association_arn");
        this.DeclareOutput("association_id");
        this.DeclareOutput("external_id");
        this.DeclareOutput("id");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterName
    {
        get => GetProperty<TerraformProperty<string>>("cluster_name");
        set => this.WithProperty("cluster_name", value);
    }

    /// <summary>
    /// The disable_session_tags attribute.
    /// </summary>
    public TerraformProperty<bool>? DisableSessionTags
    {
        get => GetProperty<TerraformProperty<bool>>("disable_session_tags");
        set => this.WithProperty("disable_session_tags", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformProperty<string>? Namespace
    {
        get => GetProperty<TerraformProperty<string>>("namespace");
        set => this.WithProperty("namespace", value);
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
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The service_account attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("service_account");
        set => this.WithProperty("service_account", value);
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
    /// The target_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TargetRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("target_role_arn");
        set => this.WithProperty("target_role_arn", value);
    }

    /// <summary>
    /// The association_arn attribute.
    /// </summary>
    public TerraformExpression AssociationArn => this["association_arn"];

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformExpression AssociationId => this["association_id"];

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    public TerraformExpression ExternalId => this["external_id"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
