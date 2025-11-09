using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_verifiedaccess_group resource.
/// </summary>
public class AwsVerifiedaccessGroup : TerraformResource
{
    public AwsVerifiedaccessGroup(string name) : base("aws_verifiedaccess_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_time");
        this.DeclareOutput("deletion_time");
        this.DeclareOutput("last_updated_time");
        this.DeclareOutput("owner");
        this.DeclareOutput("verifiedaccess_group_arn");
        this.DeclareOutput("verifiedaccess_group_id");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The policy_document attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyDocument
    {
        get => GetProperty<TerraformProperty<string>>("policy_document");
        set => this.WithProperty("policy_document", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The verifiedaccess_instance_id attribute.
    /// </summary>
    public TerraformProperty<string>? VerifiedaccessInstanceId
    {
        get => GetProperty<TerraformProperty<string>>("verifiedaccess_instance_id");
        set => this.WithProperty("verifiedaccess_instance_id", value);
    }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformExpression CreationTime => this["creation_time"];

    /// <summary>
    /// The deletion_time attribute.
    /// </summary>
    public TerraformExpression DeletionTime => this["deletion_time"];

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    public TerraformExpression LastUpdatedTime => this["last_updated_time"];

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformExpression Owner => this["owner"];

    /// <summary>
    /// The verifiedaccess_group_arn attribute.
    /// </summary>
    public TerraformExpression VerifiedaccessGroupArn => this["verifiedaccess_group_arn"];

    /// <summary>
    /// The verifiedaccess_group_id attribute.
    /// </summary>
    public TerraformExpression VerifiedaccessGroupId => this["verifiedaccess_group_id"];

}
