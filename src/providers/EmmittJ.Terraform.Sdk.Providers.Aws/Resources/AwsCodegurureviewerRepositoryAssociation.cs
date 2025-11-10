using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for kms_key_details in .
/// Nesting mode: list
/// </summary>
public class AwsCodegurureviewerRepositoryAssociationKmsKeyDetailsBlock : TerraformBlock
{
    /// <summary>
    /// The encryption_option attribute.
    /// </summary>
    public TerraformProperty<string>? EncryptionOption
    {
        get => GetProperty<TerraformProperty<string>>("encryption_option");
        set => WithProperty("encryption_option", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => WithProperty("kms_key_id", value);
    }

}

/// <summary>
/// Block type for repository in .
/// Nesting mode: list
/// </summary>
public class AwsCodegurureviewerRepositoryAssociationRepositoryBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsCodegurureviewerRepositoryAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_codegurureviewer_repository_association resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCodegurureviewerRepositoryAssociation : TerraformResource
{
    public AwsCodegurureviewerRepositoryAssociation(string name) : base("aws_codegurureviewer_repository_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("association_id");
        this.WithOutput("connection_arn");
        this.WithOutput("name");
        this.WithOutput("owner");
        this.WithOutput("provider_type");
        this.WithOutput("s3_repository_details");
        this.WithOutput("state");
        this.WithOutput("state_reason");
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
    /// Block for kms_key_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KmsKeyDetails block(s) allowed")]
    public List<AwsCodegurureviewerRepositoryAssociationKmsKeyDetailsBlock>? KmsKeyDetails
    {
        get => GetProperty<List<AwsCodegurureviewerRepositoryAssociationKmsKeyDetailsBlock>>("kms_key_details");
        set => this.WithProperty("kms_key_details", value);
    }

    /// <summary>
    /// Block for repository.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Repository block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Repository block(s) allowed")]
    public List<AwsCodegurureviewerRepositoryAssociationRepositoryBlock>? Repository
    {
        get => GetProperty<List<AwsCodegurureviewerRepositoryAssociationRepositoryBlock>>("repository");
        set => this.WithProperty("repository", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsCodegurureviewerRepositoryAssociationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsCodegurureviewerRepositoryAssociationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformExpression AssociationId => this["association_id"];

    /// <summary>
    /// The connection_arn attribute.
    /// </summary>
    public TerraformExpression ConnectionArn => this["connection_arn"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformExpression Owner => this["owner"];

    /// <summary>
    /// The provider_type attribute.
    /// </summary>
    public TerraformExpression ProviderType => this["provider_type"];

    /// <summary>
    /// The s3_repository_details attribute.
    /// </summary>
    public TerraformExpression S3RepositoryDetails => this["s3_repository_details"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The state_reason attribute.
    /// </summary>
    public TerraformExpression StateReason => this["state_reason"];

}
