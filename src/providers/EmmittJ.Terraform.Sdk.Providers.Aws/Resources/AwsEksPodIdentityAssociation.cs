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
        SetOutput("association_arn");
        SetOutput("association_id");
        SetOutput("external_id");
        SetOutput("id");
        SetOutput("tags_all");
        SetOutput("cluster_name");
        SetOutput("disable_session_tags");
        SetOutput("namespace");
        SetOutput("region");
        SetOutput("role_arn");
        SetOutput("service_account");
        SetOutput("tags");
        SetOutput("target_role_arn");
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformProperty<string> ClusterName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_name");
        set => SetProperty("cluster_name", value);
    }

    /// <summary>
    /// The disable_session_tags attribute.
    /// </summary>
    public TerraformProperty<bool> DisableSessionTags
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable_session_tags");
        set => SetProperty("disable_session_tags", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    public required TerraformProperty<string> Namespace
    {
        get => GetRequiredOutput<TerraformProperty<string>>("namespace");
        set => SetProperty("namespace", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The service_account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccount is required")]
    public required TerraformProperty<string> ServiceAccount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_account");
        set => SetProperty("service_account", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The target_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> TargetRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_role_arn");
        set => SetProperty("target_role_arn", value);
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
