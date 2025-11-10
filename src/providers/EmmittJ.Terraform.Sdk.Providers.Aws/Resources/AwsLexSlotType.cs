using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for enumeration_value in .
/// Nesting mode: set
/// </summary>
public class AwsLexSlotTypeEnumerationValueBlock : TerraformBlock
{
    /// <summary>
    /// The synonyms attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Synonyms
    {
        set => SetProperty("synonyms", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        set => SetProperty("value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLexSlotTypeTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_lex_slot_type resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLexSlotType : TerraformResource
{
    public AwsLexSlotType(string name) : base("aws_lex_slot_type", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("checksum");
        SetOutput("created_date");
        SetOutput("last_updated_date");
        SetOutput("version");
        SetOutput("create_version");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("value_selection_strategy");
    }

    /// <summary>
    /// The create_version attribute.
    /// </summary>
    public TerraformProperty<bool> CreateVersion
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("create_version");
        set => SetProperty("create_version", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The value_selection_strategy attribute.
    /// </summary>
    public TerraformProperty<string> ValueSelectionStrategy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("value_selection_strategy");
        set => SetProperty("value_selection_strategy", value);
    }

    /// <summary>
    /// Block for enumeration_value.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnumerationValue is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EnumerationValue block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10000, ErrorMessage = "Maximum 10000 EnumerationValue block(s) allowed")]
    public HashSet<AwsLexSlotTypeEnumerationValueBlock>? EnumerationValue
    {
        set => SetProperty("enumeration_value", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsLexSlotTypeTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The checksum attribute.
    /// </summary>
    public TerraformExpression Checksum => this["checksum"];

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformExpression CreatedDate => this["created_date"];

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    public TerraformExpression LastUpdatedDate => this["last_updated_date"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
