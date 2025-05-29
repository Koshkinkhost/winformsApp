using System;
using System.Collections.Generic;
using System.Linq;
using DocumentFormat.OpenXml;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace WinFormsApp1
{
    class ResumeGenerator
    {
        public void GenerateResume(string filepath, string name, string surname, string experience, string skills, string education, string template)
        {
            using (WordprocessingDocument wordDoc = WordprocessingDocument.Create(filepath, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDoc.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = new Body();

                if (template == "Классический")
                {
                    body.Append(CreateParagraph("Резюме", true, 24, JustificationValues.Center));
                    body.Append(new Paragraph(new Run(new Break())));
                    body.Append(CreateParagraph($"ФИО: {name} {surname}", false, 14));
                    body.Append(CreateParagraph($"Образование: {education}", false, 14));
                    body.Append(new Paragraph(new Run(new Break())));
                    body.Append(CreateParagraph("Опыт работы:", true, 16));
                    body.Append(CreateParagraph(experience, false, 14));
                    body.Append(new Paragraph(new Run(new Break())));
                    body.Append(CreateParagraph("Навыки:", true, 16));
                    body.Append(CreateParagraph(skills, false, 14));
                }
                else if (template == "Современный")
                {
                    body.Append(CreateParagraph($"{name} {surname}", true, 28, JustificationValues.Center));
                    body.Append(CreateParagraph($"Education: {education}", false, 14, JustificationValues.Center));
                    body.Append(new Paragraph(new Run(new Break())));
                    body.Append(CreateParagraph("Professional Experience", true, 18, JustificationValues.Left));
                    body.Append(CreateParagraph(experience, false, 14));
                    body.Append(new Paragraph(new Run(new Break())));
                    body.Append(CreateParagraph("Skills", true, 18, JustificationValues.Left));
                    body.Append(CreateParagraph(skills, false, 14));
                }
                else if (template == "Минимальный")
                {
                    body.Append(CreateParagraph($"{name} {surname}", true, 20, JustificationValues.Left));
                    body.Append(CreateParagraph(education, false, 12));
                    body.Append(CreateParagraph(experience, false, 12));
                    body.Append(CreateParagraph(skills, false, 12));
                }
                else
                {
                    // Если шаблон не указан или неизвестен, используем классический
                    body.Append(CreateParagraph("Резюме", true, 24, JustificationValues.Center));
                    body.Append(new Paragraph(new Run(new Break())));
                    body.Append(CreateParagraph($"ФИО: {name} {surname}", false, 14));
                    body.Append(CreateParagraph($"Образование: {education}", false, 14));
                    body.Append(new Paragraph(new Run(new Break())));
                    body.Append(CreateParagraph("Опыт работы:", true, 16));
                    body.Append(CreateParagraph(experience, false, 14));
                    body.Append(new Paragraph(new Run(new Break())));
                    body.Append(CreateParagraph("Навыки:", true, 16));
                    body.Append(CreateParagraph(skills, false, 14));
                }

                mainPart.Document.Append(body);
                mainPart.Document.Save();
            }
        }


        public Paragraph CreateParagraph(string text, bool bold, int fontSize = 12, JustificationValues? alignment = null)
        {
            const int DefaultFontSize = 12;

            Run run = new Run();
            RunProperties runProps = new RunProperties();

            if (bold)
                runProps.Append(new Bold());

            runProps.Append(new FontSize() { Val = (fontSize * 2).ToString() });

            run.Append(runProps);
            run.Append(new Text(text));

            ParagraphProperties paraProps = new ParagraphProperties();
            paraProps.Justification = new Justification() { Val = alignment ?? JustificationValues.Left };

            Paragraph paragraph = new Paragraph();
            paragraph.Append(paraProps);
            paragraph.Append(run);

            return paragraph;
        }

    }
}
