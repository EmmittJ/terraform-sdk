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
        set => SetProperty("customer_managed_key_enabled", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        set => SetProperty("kms_key_arn", value);
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
        SetOutput("creation_time");
        SetOutput("deletion_time");
        SetOutput("last_updated_time");
        SetOutput("owner");
        SetOutput("verifiedaccess_group_arn");
        SetOutput("verifiedaccess_group_id");
        SetOutput("description");
        SetOutput("id");
        SetOutput("policy_document");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("verifiedaccess_instance_id");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The policy_document attribute.
    /// </summary>
    public TerraformProperty<string> PolicyDocument
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_document");
        set => SetProperty("policy_document", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The verifiedaccess_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerifiedaccessInstanceId is required")]
    public required TerraformProperty<string> VerifiedaccessInstanceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("verifiedaccess_instance_id");
        set => SetProperty("verifiedaccess_instance_id", value);
    }

    /// <summary>
    /// Block for sse_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SseConfiguration block(s) allowed")]
    public List<AwsVerifiedaccessGroupSseConfigurationBlock>? SseConfiguration
    {
        set => SetProperty("sse_configuration", value);
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
