using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for dictionary in .
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionStoredInfoTypeDictionaryBlock : TerraformBlock
{
}

/// <summary>
/// Block type for large_custom_dictionary in .
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlock : TerraformBlock
{
}

/// <summary>
/// Block type for regex in .
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionStoredInfoTypeRegexBlock : TerraformBlock
{
    /// <summary>
    /// The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.
    /// </summary>
    public List<TerraformProperty<double>>? GroupIndexes
    {
        set => SetProperty("group_indexes", value);
    }

    /// <summary>
    /// Pattern defining the regular expression.
    /// Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    public required TerraformProperty<string> Pattern
    {
        set => SetProperty("pattern", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataLossPreventionStoredInfoTypeTimeoutsBlock : TerraformBlock
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
/// Manages a google_data_loss_prevention_stored_info_type resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataLossPreventionStoredInfoType : TerraformResource
{
    public GoogleDataLossPreventionStoredInfoType(string name) : base("google_data_loss_prevention_stored_info_type", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("parent");
        SetOutput("stored_info_type_id");
    }

    /// <summary>
    /// A description of the info type.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// User set display name of the info type.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// The parent of the info type in any of the following formats:
    /// 
    /// * &#39;projects/{{project}}&#39;
    /// * &#39;projects/{{project}}/locations/{{location}}&#39;
    /// * &#39;organizations/{{organization_id}}&#39;
    /// * &#39;organizations/{{organization_id}}/locations/{{location}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent");
        set => SetProperty("parent", value);
    }

    /// <summary>
    /// The storedInfoType ID can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is 100
    /// characters. Can be empty to allow the system to generate one.
    /// </summary>
    public TerraformProperty<string> StoredInfoTypeId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stored_info_type_id");
        set => SetProperty("stored_info_type_id", value);
    }

    /// <summary>
    /// Block for dictionary.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dictionary block(s) allowed")]
    public List<GoogleDataLossPreventionStoredInfoTypeDictionaryBlock>? Dictionary
    {
        set => SetProperty("dictionary", value);
    }

    /// <summary>
    /// Block for large_custom_dictionary.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LargeCustomDictionary block(s) allowed")]
    public List<GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlock>? LargeCustomDictionary
    {
        set => SetProperty("large_custom_dictionary", value);
    }

    /// <summary>
    /// Block for regex.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Regex block(s) allowed")]
    public List<GoogleDataLossPreventionStoredInfoTypeRegexBlock>? Regex
    {
        set => SetProperty("regex", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataLossPreventionStoredInfoTypeTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The resource name of the info type. Set by the server.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
