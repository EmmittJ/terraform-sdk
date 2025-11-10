using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for sse_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessGroupSseConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The customer_managed_key_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CustomerManagedKeyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("customer_managed_key_enabled");
        set => WithProperty("customer_managed_key_enabled", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_arn");
        set => WithProperty("kms_key_arn", value);
    }

}

/// <summary>
/// Manages a aws_verifiedaccess_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The verifiedaccess_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerifiedaccessInstanceId is required")]
    public required TerraformProperty<string> VerifiedaccessInstanceId
    {
        get => GetProperty<TerraformProperty<string>>("verifiedaccess_instance_id");
        set => this.WithProperty("verifiedaccess_instance_id", value);
    }

    /// <summary>
    /// Block for sse_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SseConfiguration block(s) allowed")]
    public List<AwsVerifiedaccessGroupSseConfigurationBlock>? SseConfiguration
    {
        get => GetProperty<List<AwsVerifiedaccessGroupSseConfigurationBlock>>("sse_configuration");
        set => this.WithProperty("sse_configuration", value);
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
